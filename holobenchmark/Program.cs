﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace holobenchmark
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain(args[2], args[1], args[0]));
		}
	}
}
