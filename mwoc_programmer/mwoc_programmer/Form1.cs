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

		List<long> patternTime = new List<long>();
		List<int> patternPower = new List<int>();

		double totalShowTime = 0;

		

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<int> testList = new List<int>() { 1, 2, 3 };

			//sets the column width to a more reasonable size
			for (int i = 0; i < 4; i++)
			{
				cmdViewer.Columns[i].Width = 60;
			}

			//cmdViewer.Rows[0].Cells[0].Value = testList[0];


			//stopwatchText.Text = cmdViewer.Rows[0].Cells[2].Value.ToString();
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
			updateTotalTime(double.Parse(manual_TimeBox.Text));
			cmdViewer.Rows.Add(totalShowTime,manual_TimeBox.Text, manual_PowerBox.Text, manual_ColorBox.Text);
		}

		

		//updates total time, only provide it time in ms!
		public void updateTotalTime(double addedTime)
		{
			totalShowTime += (addedTime * 0.001);
		}

		private void patternBtn_MouseUp(object sender, MouseEventArgs e)
		{
			if(watch.IsRunning)
			{
				//system.formatexception
				watch.Stop();
				

				try
				{
					patternTime.Add(watch.ElapsedMilliseconds);
					patternPower.Add(int.Parse(patternPowerBox.Text));
				}
				catch(FormatException)
				{
					MessageBox.Show("Must enter a valid power and color value");
					watch.Stop();
					patternTime.Clear();
					patternPower.Clear();
					watch.Reset();
				}
				
				watch.Reset();
			}

			watch.Start();
		}

		private void patternBtn_MouseDown(object sender, MouseEventArgs e)
		{
			//if watch is running, this means it's counting the off time
			if(watch.IsRunning)
			{
				watch.Stop();
				patternTime.Add(watch.ElapsedMilliseconds);
				patternPower.Add(0);
				watch.Reset();

			}

			watch.Start();

		}

		private void patternListBtn_Click(object sender, EventArgs e)
		{
			if(watch.IsRunning)
			{
				watch.Stop();
			}

			watch.Reset();

			

			for(int i = 0; i < patternTime.Count; i++)
			{
				updateTotalTime(patternTime[i]);
				cmdViewer.Rows.Add(totalShowTime, patternTime[i], patternPower[i], patternColorBox.Text);
			}

			//updateTotalTime(10);
			//cmdViewer.Rows.Add(totalShowTime, 10, 0, patternColorBox.Text);

			patternTime.Clear();
			patternPower.Clear();
		}
	}
}
