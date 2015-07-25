using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace holobenchmark
{
	public partial class frmPleaseWait : Form
	{
		public frmPleaseWait(string message)
		{
			InitializeComponent();
			lblMessage.Text = message;
		}
	}
}
