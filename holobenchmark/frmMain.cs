using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

using MediaInfoDotNet;

enum x265Result
{
	Encoder,
	Build,
	CPU,
	FPS,
	Duration
}

namespace holobenchmark
{
	public partial class frmMain : Form
	{
		string _file;
		string _compiler;
		string _lang;

		int _framecount;
		int _bitdepth;
		int _chroma;
		string _preset;
		string _tune;
		string _value = "26.0";

		string _checksum;

		string DIR = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		string TEMP = Path.Combine(Path.GetTempPath(), "holo");
		string HEVC;
		string FFMPG;

		Form wait = new frmPleaseWait("Please Wait\nGetting CRC32");

		public frmMain(string file, string compiler, string lang)
		{
			InitializeComponent();
			Icon = Properties.Resources.Benchmark;
			Text = $"Holo Benchmark ({compiler.ToUpper()}) v{Application.ProductVersion}";

			_file = file;
			_compiler = compiler;
			_lang = lang;
		}

		private void frmBenchmark_Load(object sender, EventArgs e)
		{
			FFMPG = Path.Combine(DIR, "plugins", "ffmpeg", "ffmpeg");
			HEVC = Path.Combine(DIR, "plugins", "x265" + _compiler, "x265");

			if (!Directory.Exists(TEMP))
				Directory.CreateDirectory(TEMP);

			lblFile.Text = $"{Path.GetDirectoryName(_file)}\n{Path.GetFileName(_file)}";

			MediaFile AVI = new MediaFile(_file);
			if (AVI.Video.Count > 0)
			{
				var Video = AVI.Video[0];

				var Codec = Video.format;
				var Resolution = $"{Video.width}x{Video.height}";
				var Duration = TimeSpan.FromMilliseconds(Video.duration);
				var FrameRate = Video.frameRateGet;
				var BitDepth = Video.bitDepth;
				var Chroma = $"{Video.colorSpace} {Video.chromaSubSampling}";

				lblMediaData.Text = $"{Codec}\n{Resolution}\n{Duration.Hours:D2}h {Duration.Minutes:D2}m {Duration.Seconds:D2}s\n{FrameRate} fps\n{BitDepth} bit per colour ({BitDepth * 3} bit)\n{Chroma}";

				_framecount = Video.frameCount;
				_bitdepth = Video.bitDepth;
				_chroma = Convert.ToInt32(Video.chromaSubSampling.Replace(":", null));
			}

			cboPreset.SelectedIndex = 5;
			cboTune.SelectedIndex = 0;
			trkValue.Value = 260;
		}

		private void Benchmark_Shown(object sender, EventArgs e)
		{
			bgwCRC32.RunWorkerAsync(_file); // get CRC32
			wait.Show();
		}

		private void cboPreset_SelectedIndexChanged(object sender, EventArgs e)
		{
			_preset = cboPreset.Text;
		}

		private void cboTune_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tune = cboTune.Text;
		}

		private void trkValue_ValueChanged(object sender, EventArgs e)
		{
			_value = $"{Convert.ToDouble(trkValue.Value) * 0.1:0.0}";
			lblValue.Text = "@ " + _value;
		}
		private void btnScreenShot_Click(object sender, EventArgs e)
		{
			var frm = ActiveForm;
			using (var bmp = new Bitmap(frm.Width, frm.Height))
			{
				frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
				bmp.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"IFME_BENCHMARK_{DateTime.Now:yyyyMMdd_HHmmss}.PNG"));

				MessageBox.Show("Screenshot has been saved on your desktop");
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!bgwBenchmark.IsBusy)
			{
				List<object> gg = new List<object>
				{
					_file,
					_framecount,
					_bitdepth,
					_chroma,
					_preset,
					_tune,
					_value,
					txtCmd.Text
				};

				bgwBenchmark.RunWorkerAsync(gg);
				btnStart.Text = "&STOP";
			}
			else
			{
				var msgbox = MessageBox.Show("Do you want to stop benchmark?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (msgbox == DialogResult.Yes)
				{
					Kill();
					btnStart.Text = "&START";
					bgwBenchmark.CancelAsync();
				}
			}
		}

		private void bgwBenchmark_DoWork(object sender, DoWorkEventArgs e)
		{
			List<object> argList = e.Argument as List<object>;
			string file = (string)argList[0];
			int framecount = (int)argList[1];
			int bitdepth = (int)argList[2];
			int chroma = (int)argList[3];
			string preset = (string)argList[4];
			string tune = (string)argList[5];
			string value = (string)argList[6];
			string cmd = (string)argList[7];

			string ten = bitdepth == 10 ? "10le" : null;
			string tun = string.Equals(tune, "off") ? null : "--tune " + tune;

			string NULL = OS.Null;

			bgwRead.RunWorkerAsync(); // start read

			Run($"\"{FFMPG}\" -i \"{file}\" -f yuv4mpegpipe -pix_fmt yuv{chroma}p{ten} -strict -1 - 2> {NULL} | \"{HEVC}-{bitdepth:00}\" --y4m - -p {preset} {tun} --crf {value} -f {framecount} {cmd} -o benchmark.hevc 2> result.txt 1>&2");
            ResultRead();
		}

		private void bgwBenchmark_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bgwRead.CancelAsync(); // stop read
			Console.Title = "Please Wait...";

			string CpuName = MachineInfo.Get("Name");
			string CpuSpeed = MachineInfo.Get("CurrentClockSpeed");
			string Encoder = ResultGet(x265Result.Encoder);
			string Build = ResultGet(x265Result.Build);
			string ISet = ResultGet(x265Result.CPU);
			string AvgFps = ResultGet(x265Result.FPS);
			string Duration = ResultGet(x265Result.Duration);

			lblResultData.Text = $"{CpuName} (~{CpuSpeed} MHz)\n{OS.FriendlyName}\n{Encoder}\n{Build}\n{ISet}\n{AvgFps}\n{Duration}";

			btnStart.Text = "&START";

			foreach (var item in Directory.GetFiles(TEMP))
				File.Delete(item);
		}

		string _infoEncoder;
		string _infoBuild;
		string _infoCpu;
		string _infoDuration;
		string _infoFps;

		string ResultGet(x265Result type)
		{
			switch (type)
			{
				case x265Result.Encoder:
					return _infoEncoder;
				case x265Result.Build:
					return _infoBuild;
				case x265Result.CPU:
					return _infoCpu;
				case x265Result.FPS:
					return _infoFps;
				case x265Result.Duration:
					return _infoDuration;
				default:
					return "No Data";
			}
		}

		void ResultRead()
		{
			_infoEncoder = null;
			_infoBuild = null;
			_infoCpu = null;
			_infoDuration = null;
			_infoFps = null;

			foreach (var item in File.ReadAllLines(Path.Combine(TEMP, "result.txt")))
			{
				if (item.Contains("encoder version"))
				{
					for (int i = item.IndexOf(':') + 2; i < item.Length; i++)
					{
						_infoEncoder += item[i];
					}
				}

				if (item.Contains("build info"))
				{
					for (int i = item.IndexOf(':') + 13; i < item.Length; i++)
					{
						_infoBuild += item[i];
					}
				}

				if (item.Contains("using cpu capabilities"))
				{
					for (int i = 37; i < item.Length; i++)
					{
						_infoCpu += item[i];
					}
				}

				if (item.Contains("encoded"))
				{
					for (int i = item.IndexOf("in") + 3; i < item.Length; i++)
					{
						if (item[i] == ' ')
							break;

						_infoDuration += item[i];
					}

					for (int i = item.IndexOf('(') + 1; i < item.Length; i++)
					{
						if (item[i] == ')')
							break;

						_infoFps += item[i];
					}
				}
			}
		}

		private void bgwRead_DoWork(object sender, DoWorkEventArgs e)
		{
			while (true)
			{
				InvokeStatus(Console.Title.Replace("x265",""));

				if (bgwRead.CancellationPending)
				{
					e.Cancel = true;
					return;
				}
			}
		}

		private void bgwRead_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			InvokeStatus("Done!");
		}

		private void InvokeStatus(string s)
		{
			if (InvokeRequired)
				BeginInvoke(new MethodInvoker(() => lblStatus.Text = s));
			else
				lblStatus.Text = s;
		}

		private int Run(string command)
		{
			string exe;
			string arg;

			if (OS.IsWindows)
			{
				exe = "cmd";
				arg = "/c START \"HOLO\" /B " + command; // allow max args to pass, Windows limit 8191
			}
			else
			{
				exe = "bash";
				arg = "-c '" + command + "'"; // POSIX has 2091769, silly Windows
			}

			var p = new Process();
			p.StartInfo = new ProcessStartInfo(exe, arg)
			{
				UseShellExecute = false,
				WorkingDirectory = TEMP,
			};

			p.Start();
			p.WaitForExit();

			return p.ExitCode;
		}

		private void Kill()
		{
			string[] proc = { "x265-08", "x265-10", "x265-12", "ffmpeg" };
			foreach (var item in proc)
			{
				Process[] Task = Process.GetProcessesByName(item);
				foreach (Process P in Task)
				{
					P.Kill();
				}
			}
		}

		private void bgwCRC32_DoWork(object sender, DoWorkEventArgs e)
		{
			_checksum = CRC32.GetFile((string)e.Argument);
		}

		private void bgwCRC32_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			lblFile.Text += "\n CRC32: " + _checksum;
			btnStart.Enabled = true;
			wait.Close();
		}
	}
}
