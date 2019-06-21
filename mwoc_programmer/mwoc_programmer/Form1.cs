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
using System.IO;
using System.Timers;
using Timer = System.Timers.Timer;

namespace mwoc_programmer
{
	public partial class Form1 : Form
	{

		Stopwatch watch = new Stopwatch();
		Timer visTimer = new Timer();

		List<long> patternTime = new List<long>();
		List<int> patternPower = new List<int>();

		Bitmap waterCircle = Properties.Resources.watercircle;
		Bitmap greyCircle = Properties.Resources.greycircle;
		Bitmap redCircle = Properties.Resources.redcircle;
		Bitmap blueCircle = Properties.Resources.bluecircle;
		Bitmap yellowCircle = Properties.Resources.yellowcircle;
		Bitmap greenCircle = Properties.Resources.greencircle;

		string printCmd;
		string convertedColor;

		double totalShowTime = 0;

		int countdown = 0;

		string outputPath = @"c:\users\kevin\desktop\mini-woc\show data\outputShow.dat";

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

		private void outputToFileBtn_Click(object sender, EventArgs e)
		{
			if(!File.Exists(outputPath)) //if file does not exist
			{
				MessageBox.Show("File does not exist at path. Please set path destination or create file. \n" + "Path: " +  outputPath);
			} else
			{

				File.WriteAllText(outputPath, string.Empty); //clears the file before writing new show data

				using (System.IO.StreamWriter file =
					new System.IO.StreamWriter(outputPath, true))
				{

					for (int i = 0; i < cmdViewer.RowCount-1; i++) //-1 because it counts the blank row
					{

						switch(cmdViewer.Rows[i].Cells[3].Value)
						{
							case "Red":
								convertedColor = "0";
								break;
							case "Blue":
								convertedColor = "1";
								break;
							case "Green":
								convertedColor = "2";
								break;
							case "Yellow":
								convertedColor = "3";
								break;
							default:
								convertedColor = "0"; //this should never happen since it's a dropbox but this catches any trouble
								break;
						}

						printCmd = 
							cmdViewer.Rows[i].Cells[1].Value.ToString() + " " + //time value
							cmdViewer.Rows[i].Cells[2].Value.ToString() + " " + //power value
							convertedColor; //color value

						file.WriteLine(printCmd);
					}
				}

				cmdViewer.Rows.Clear();
			}
		}

		private void startVisualizerBtn_Click(object sender, EventArgs e)
		{
			visTimer.Elapsed += visTimer_Elapsed;
			visTimer.Interval = 1000;
			

			visTimer.Start();
		}

		private void visTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		 {
			if(countdown < 3)
			{
				switch(countdown)
				{
					case 0:
						timeIndicatorImg.Image = redCircle;
						countdown++;
						break;
					case 1:
						timeIndicatorImg.Image = yellowCircle;
						countdown++;
						break;
					case 2:
						timeIndicatorImg.Image = greenCircle;
						countdown++;
						break;
				}
			}




		}
	}
}