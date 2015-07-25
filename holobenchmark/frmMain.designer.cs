namespace holobenchmark
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictBanner = new System.Windows.Forms.PictureBox();
			this.grpFile = new System.Windows.Forms.GroupBox();
			this.lblFile = new System.Windows.Forms.Label();
			this.grpMediaInfo = new System.Windows.Forms.GroupBox();
			this.lblMediaData = new System.Windows.Forms.Label();
			this.lblMediaInfo = new System.Windows.Forms.Label();
			this.grpVideoConfig = new System.Windows.Forms.GroupBox();
			this.txtCmd = new System.Windows.Forms.TextBox();
			this.lblCmd = new System.Windows.Forms.Label();
			this.lblValue = new System.Windows.Forms.Label();
			this.trkValue = new System.Windows.Forms.TrackBar();
			this.lblCRF = new System.Windows.Forms.Label();
			this.cboTune = new System.Windows.Forms.ComboBox();
			this.lblTune = new System.Windows.Forms.Label();
			this.cboPreset = new System.Windows.Forms.ComboBox();
			this.lblPreset = new System.Windows.Forms.Label();
			this.grpResult = new System.Windows.Forms.GroupBox();
			this.btnScreenShot = new System.Windows.Forms.Button();
			this.lblResultData = new System.Windows.Forms.Label();
			this.lblResultInfo = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.bgwBenchmark = new System.ComponentModel.BackgroundWorker();
			this.lblStatus = new System.Windows.Forms.Label();
			this.bgwRead = new System.ComponentModel.BackgroundWorker();
			this.bgwCRC32 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.pictBanner)).BeginInit();
			this.grpFile.SuspendLayout();
			this.grpMediaInfo.SuspendLayout();
			this.grpVideoConfig.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkValue)).BeginInit();
			this.grpResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictBanner
			// 
			this.pictBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictBanner.BackColor = System.Drawing.Color.Black;
			this.pictBanner.Image = global::holobenchmark.Properties.Resources.Benchmark_Banner;
			this.pictBanner.Location = new System.Drawing.Point(0, 0);
			this.pictBanner.Name = "pictBanner";
			this.pictBanner.Size = new System.Drawing.Size(500, 64);
			this.pictBanner.TabIndex = 0;
			this.pictBanner.TabStop = false;
			// 
			// grpFile
			// 
			this.grpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpFile.Controls.Add(this.lblFile);
			this.grpFile.Location = new System.Drawing.Point(12, 70);
			this.grpFile.Name = "grpFile";
			this.grpFile.Size = new System.Drawing.Size(476, 100);
			this.grpFile.TabIndex = 1;
			this.grpFile.TabStop = false;
			this.grpFile.Text = "File";
			// 
			// lblFile
			// 
			this.lblFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFile.Location = new System.Drawing.Point(6, 16);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(464, 74);
			this.lblFile.TabIndex = 0;
			this.lblFile.Text = "OnePlus_4KRaw.mp4\r\nD:\\Users\\Anime4000\\Videos";
			this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grpMediaInfo
			// 
			this.grpMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpMediaInfo.Controls.Add(this.lblMediaData);
			this.grpMediaInfo.Controls.Add(this.lblMediaInfo);
			this.grpMediaInfo.Location = new System.Drawing.Point(12, 176);
			this.grpMediaInfo.Name = "grpMediaInfo";
			this.grpMediaInfo.Size = new System.Drawing.Size(476, 130);
			this.grpMediaInfo.TabIndex = 2;
			this.grpMediaInfo.TabStop = false;
			this.grpMediaInfo.Text = "Media Info";
			// 
			// lblMediaData
			// 
			this.lblMediaData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMediaData.Location = new System.Drawing.Point(136, 16);
			this.lblMediaData.Name = "lblMediaData";
			this.lblMediaData.Size = new System.Drawing.Size(334, 104);
			this.lblMediaData.TabIndex = 1;
			this.lblMediaData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMediaInfo
			// 
			this.lblMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblMediaInfo.Location = new System.Drawing.Point(6, 16);
			this.lblMediaInfo.Name = "lblMediaInfo";
			this.lblMediaInfo.Size = new System.Drawing.Size(124, 104);
			this.lblMediaInfo.TabIndex = 0;
			this.lblMediaInfo.Text = "Codec:\r\nResolution:\r\nDuration:\r\nFrame Rate:\r\nBit Depth:\r\nChroma Subsampling:";
			this.lblMediaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpVideoConfig
			// 
			this.grpVideoConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpVideoConfig.Controls.Add(this.txtCmd);
			this.grpVideoConfig.Controls.Add(this.lblCmd);
			this.grpVideoConfig.Controls.Add(this.lblValue);
			this.grpVideoConfig.Controls.Add(this.trkValue);
			this.grpVideoConfig.Controls.Add(this.lblCRF);
			this.grpVideoConfig.Controls.Add(this.cboTune);
			this.grpVideoConfig.Controls.Add(this.lblTune);
			this.grpVideoConfig.Controls.Add(this.cboPreset);
			this.grpVideoConfig.Controls.Add(this.lblPreset);
			this.grpVideoConfig.Location = new System.Drawing.Point(12, 312);
			this.grpVideoConfig.Name = "grpVideoConfig";
			this.grpVideoConfig.Size = new System.Drawing.Size(476, 130);
			this.grpVideoConfig.TabIndex = 3;
			this.grpVideoConfig.TabStop = false;
			this.grpVideoConfig.Text = "&x265 Configuration";
			// 
			// txtCmd
			// 
			this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCmd.Location = new System.Drawing.Point(6, 102);
			this.txtCmd.Name = "txtCmd";
			this.txtCmd.Size = new System.Drawing.Size(464, 20);
			this.txtCmd.TabIndex = 8;
			this.txtCmd.Text = "--asm \"MMX2,SSE,SSE2\"";
			// 
			// lblCmd
			// 
			this.lblCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCmd.AutoSize = true;
			this.lblCmd.Location = new System.Drawing.Point(6, 86);
			this.lblCmd.Name = "lblCmd";
			this.lblCmd.Size = new System.Drawing.Size(105, 13);
			this.lblCmd.TabIndex = 7;
			this.lblCmd.Text = "&Extra command-line:";
			// 
			// lblValue
			// 
			this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(428, 22);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(42, 13);
			this.lblValue.TabIndex = 6;
			this.lblValue.Text = "@ 26.0";
			// 
			// trkValue
			// 
			this.trkValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trkValue.Location = new System.Drawing.Point(263, 38);
			this.trkValue.Maximum = 510;
			this.trkValue.Name = "trkValue";
			this.trkValue.Size = new System.Drawing.Size(207, 45);
			this.trkValue.TabIndex = 5;
			this.trkValue.TickFrequency = 10;
			this.trkValue.ValueChanged += new System.EventHandler(this.trkValue_ValueChanged);
			// 
			// lblCRF
			// 
			this.lblCRF.AutoSize = true;
			this.lblCRF.Location = new System.Drawing.Point(260, 22);
			this.lblCRF.Name = "lblCRF";
			this.lblCRF.Size = new System.Drawing.Size(27, 13);
			this.lblCRF.TabIndex = 4;
			this.lblCRF.Text = "&CRF";
			// 
			// cboTune
			// 
			this.cboTune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTune.FormattingEnabled = true;
			this.cboTune.Items.AddRange(new object[] {
            "off",
            "psnr",
            "ssim",
            "grain",
            "zerolatency",
            "fastdecode"});
			this.cboTune.Location = new System.Drawing.Point(136, 38);
			this.cboTune.Name = "cboTune";
			this.cboTune.Size = new System.Drawing.Size(121, 21);
			this.cboTune.TabIndex = 3;
			this.cboTune.SelectedIndexChanged += new System.EventHandler(this.cboTune_SelectedIndexChanged);
			// 
			// lblTune
			// 
			this.lblTune.AutoSize = true;
			this.lblTune.Location = new System.Drawing.Point(133, 22);
			this.lblTune.Name = "lblTune";
			this.lblTune.Size = new System.Drawing.Size(35, 13);
			this.lblTune.TabIndex = 2;
			this.lblTune.Text = "&Tune:";
			// 
			// cboPreset
			// 
			this.cboPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPreset.FormattingEnabled = true;
			this.cboPreset.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "slower",
            "veryslow",
            "placebo"});
			this.cboPreset.Location = new System.Drawing.Point(9, 38);
			this.cboPreset.Name = "cboPreset";
			this.cboPreset.Size = new System.Drawing.Size(121, 21);
			this.cboPreset.TabIndex = 1;
			this.cboPreset.SelectedIndexChanged += new System.EventHandler(this.cboPreset_SelectedIndexChanged);
			// 
			// lblPreset
			// 
			this.lblPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblPreset.AutoSize = true;
			this.lblPreset.Location = new System.Drawing.Point(6, 22);
			this.lblPreset.Name = "lblPreset";
			this.lblPreset.Size = new System.Drawing.Size(42, 13);
			this.lblPreset.TabIndex = 0;
			this.lblPreset.Text = "&Preset:";
			// 
			// grpResult
			// 
			this.grpResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpResult.Controls.Add(this.btnScreenShot);
			this.grpResult.Controls.Add(this.lblResultData);
			this.grpResult.Controls.Add(this.lblResultInfo);
			this.grpResult.Location = new System.Drawing.Point(12, 448);
			this.grpResult.Name = "grpResult";
			this.grpResult.Size = new System.Drawing.Size(476, 130);
			this.grpResult.TabIndex = 4;
			this.grpResult.TabStop = false;
			this.grpResult.Text = "Result";
			// 
			// btnScreenShot
			// 
			this.btnScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnScreenShot.Image = global::holobenchmark.Properties.Resources.disk;
			this.btnScreenShot.Location = new System.Drawing.Point(446, 100);
			this.btnScreenShot.Name = "btnScreenShot";
			this.btnScreenShot.Size = new System.Drawing.Size(24, 24);
			this.btnScreenShot.TabIndex = 7;
			this.btnScreenShot.UseVisualStyleBackColor = true;
			this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
			// 
			// lblResultData
			// 
			this.lblResultData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResultData.Location = new System.Drawing.Point(136, 16);
			this.lblResultData.Name = "lblResultData";
			this.lblResultData.Size = new System.Drawing.Size(334, 108);
			this.lblResultData.TabIndex = 1;
			this.lblResultData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResultInfo
			// 
			this.lblResultInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblResultInfo.Location = new System.Drawing.Point(6, 16);
			this.lblResultInfo.Name = "lblResultInfo";
			this.lblResultInfo.Size = new System.Drawing.Size(124, 108);
			this.lblResultInfo.TabIndex = 0;
			this.lblResultInfo.Text = "CPU Model:\r\nOperating System:\r\nEncoder:\r\nBuild:\r\nInstruction Set used:\r\nAverage F" +
    "PS:\r\nDuration:";
			this.lblResultInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(388, 584);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(100, 44);
			this.btnStart.TabIndex = 5;
			this.btnStart.Text = "&START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// bgwBenchmark
			// 
			this.bgwBenchmark.WorkerSupportsCancellation = true;
			this.bgwBenchmark.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBenchmark_DoWork);
			this.bgwBenchmark.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBenchmark_RunWorkerCompleted);
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Location = new System.Drawing.Point(12, 584);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(370, 44);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Ready";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bgwRead
			// 
			this.bgwRead.WorkerSupportsCancellation = true;
			this.bgwRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRead_DoWork);
			this.bgwRead.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRead_RunWorkerCompleted);
			// 
			// bgwCRC32
			// 
			this.bgwCRC32.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCRC32_DoWork);
			this.bgwCRC32.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCRC32_RunWorkerCompleted);
			// 
			// Benchmark
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(500, 640);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.grpResult);
			this.Controls.Add(this.grpVideoConfig);
			this.Controls.Add(this.grpMediaInfo);
			this.Controls.Add(this.grpFile);
			this.Controls.Add(this.pictBanner);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(516, 678);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(516, 678);
			this.Name = "Benchmark";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Benchmark";
			this.Load += new System.EventHandler(this.frmBenchmark_Load);
			this.Shown += new System.EventHandler(this.Benchmark_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictBanner)).EndInit();
			this.grpFile.ResumeLayout(false);
			this.grpMediaInfo.ResumeLayout(false);
			this.grpVideoConfig.ResumeLayout(false);
			this.grpVideoConfig.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkValue)).EndInit();
			this.grpResult.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictBanner;
		private System.Windows.Forms.GroupBox grpFile;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.GroupBox grpMediaInfo;
		private System.Windows.Forms.Label lblMediaInfo;
		private System.Windows.Forms.Label lblMediaData;
		private System.Windows.Forms.GroupBox grpVideoConfig;
		private System.Windows.Forms.GroupBox grpResult;
		private System.Windows.Forms.Label lblResultInfo;
		private System.Windows.Forms.Label lblResultData;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ComboBox cboPreset;
		private System.Windows.Forms.Label lblPreset;
		private System.Windows.Forms.ComboBox cboTune;
		private System.Windows.Forms.Label lblTune;
		private System.Windows.Forms.Label lblCRF;
		private System.Windows.Forms.TrackBar trkValue;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.TextBox txtCmd;
		private System.Windows.Forms.Label lblCmd;
		private System.ComponentModel.BackgroundWorker bgwBenchmark;
		private System.Windows.Forms.Label lblStatus;
		private System.ComponentModel.BackgroundWorker bgwRead;
		private System.Windows.Forms.Button btnScreenShot;
		private System.ComponentModel.BackgroundWorker bgwCRC32;
	}
}