using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace holobenchmark
{
	class MachineInfo
	{
		public static string Get(string key)
		{
			if (OS.IsWindows)
			{
				// ref: http://www.codeproject.com/Articles/17973/How-To-Get-Hardware-Information-CPU-ID-MainBoard-I
				ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + "Win32_Processor");
				string data = null;

				try
				{
					foreach (ManagementObject item in searcher.Get())
					{
						data = String.Format("{0}", item[key]);
					}
				}
				catch
				{
					data = "error";
				}

				return data;
			}
			else
			{
				return "Unsupported";
			}
		}
	}
}
