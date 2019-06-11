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

		//lists that hold the commands before they're added to the final arrays
		List<int> tempTime = new List<int>();
		List<int> tempPower = new List<int>();
		List<int> tempColor = new List<int>();

		//final lists that will be printed out at the end
		List<int> time = new List<int>();
		List<int> power = new List<int>();
		List<int> color = new List<int>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		//runs when timer button is held
		private void clickTimer_MouseDown(object sender, MouseEventArgs e)
		{
			watch.Start();
		}

		//runs when timer button is released
		private void clickTimer_MouseUp(object sender, MouseEventArgs e)
		{
			watch.Stop();
			stopwatchText.Text = watch.ElapsedMilliseconds.ToString();
			watch.Reset();
		}

		private void manualAddToList_Click(object sender, EventArgs e)
		{
			//cmdViewer.
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}
	}
}
