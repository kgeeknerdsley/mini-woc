using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace mwoc_programmer
{
	public partial class Form1 : Form
	{

		Stopwatch watch = new Stopwatch();

		public Form1()
		{
			InitializeComponent();
		}


		private void clickTimer_MouseDown(object sender, MouseEventArgs e)
		{
			watch.Start();
		}

		private void clickTimer_MouseUp(object sender, MouseEventArgs e)
		{
			watch.Stop();
			stopwatchText.Text = watch.ElapsedMilliseconds.ToString();
			watch.Reset();
		}
	}
}
