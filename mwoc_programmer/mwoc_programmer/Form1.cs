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
using Microsoft.Win32;
using Timer = System.Timers.Timer;

namespace mwoc_programmer
{
	public partial class Form1 : Form
	{

		Stopwatch watch = new Stopwatch();
		Stopwatch audioWatch = new Stopwatch();
		Timer visTimer = new Timer();

		List<long> patternTime = new List<long>();
		List<int> patternPower = new List<int>();

		//list that holds saved data when we switch lists
		List<List<string>> savedFountain1 = new List<List<string>>();
		List<List<string>> savedFountain2 = new List<List<string>>();
		List<List<string>> savedFountain3 = new List<List<string>>();
		List<List<string>> savedFountain4 = new List<List<string>>();
		List<List<string>> savedFountain5 = new List<List<string>>();

		List<List<string>> currentFtnList = new List<List<string>>();

		Bitmap waterCircle = Properties.Resources.watercircle;
		Bitmap greyCircle = Properties.Resources.greycircle;
		Bitmap redCircle = Properties.Resources.redcircle;
		Bitmap blueCircle = Properties.Resources.bluecircle;
		Bitmap yellowCircle = Properties.Resources.yellowcircle;
		Bitmap greenCircle = Properties.Resources.greencircle;

		string printCmd;
		string convertedColor;
		string cmdIncoming;
		string loadedTime;
		string loadedPower;
		string loadedColor;

		bool visAudioStarted = false;

		double totalShowTime = 0;

		int countdown;
		int visTracker;
		int currentFountain = 1;

		string outputPath = @"c:\users\kevin\desktop\mini-woc\show data\outputShow.dat";
		string audioPath = @"c:\users\kevin\desktop\mini-woc\mwoc_programmer\mwoc_programmer\resources\hello_seattle.mp3";

		//string outputPath = @"C:\Users\Kevin Worsley\Desktop\Personal Projects\mini-woc\show data\outputShow.dat";
		//string audioPath = @"C:\Users\Kevin Worsley\Desktop\Personal Projects\mini-woc\mwoc_programmer\mwoc_programmer\Resources\hello_seattle.mp3";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//sets the column width to a more reasonable size
			for (int i = 0; i < 4; i++)
			{
				cmdViewer.Columns[i].Width = 60;
			}

			//sets elapsed event for the visualization function
			visTimer.Elapsed += visTimer_Elapsed;

			//attempt to precache the music so it doesn't waste time loading when needed
			audioPlayer.URL = audioPath;
			audioPlayer.Ctlcontrols.stop();
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

		//adds command to list manually
		private void manualAddToList_Click(object sender, EventArgs e)
		{
			updateTotalTime(double.Parse(manual_TimeBox.Text));
			cmdViewer.Rows.Add(totalShowTime,manual_TimeBox.Text, manual_PowerBox.Text, manual_ColorBox.Text);
		}

		//updates total show time parameter 
		//only provide it time in ms!
		public void updateTotalTime(double addedTime)
		{
			totalShowTime += (addedTime * 0.001);
		}

		//measures the time the fountain is off in a pattern
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

		//measures the time the fountain is on in a pattern
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

		//add the assembled pattern onto the list, then forget it
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

		//write command list to the output file in proper format
		//TODO: add a power 0 section to the end so the final command doesn't go forever
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
						//TODO: Replace with the color conversion function
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

		//starts the visualizer
		private void startVisualizerBtn_Click(object sender, EventArgs e)
		{
			visTimer.Stop();
			
			visTimer.Interval = 1000;
			countdown = 0;
			visTracker = 0;
			

			visTimer.Start();
		}

		//fires whenever the visualizer's timer ticks over, updates the water height, color, and how long it's on for
		//TODO: make the color function work
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
						Console.WriteLine(countdown);
						break;
				}
			} else
			{
				timeIndicatorImg.Image = Properties.Resources.check;

				if(!visAudioStarted)
				{
					audioPlayer.URL = audioPath;
					visAudioStarted = true;
				}
				

				if (visTracker < cmdViewer.RowCount - 1) //if the row we're checking hasn't exceeded the count
				{
					if (Convert.ToInt16(cmdViewer.Rows[visTracker].Cells[2].Value) == 0)
					{
						waterImg_Low.Image = greyCircle;
						waterImg_Med.Image = greyCircle;
						waterImg_High.Image = greyCircle;
					}
					else if (Convert.ToInt16(cmdViewer.Rows[visTracker].Cells[2].Value) < 85) //low water
					{
						waterImg_Low.Image = waterCircle;
						waterImg_Med.Image = greyCircle;
						waterImg_High.Image = greyCircle;

					}
					else if (Convert.ToInt16(cmdViewer.Rows[visTracker].Cells[2].Value) >= 85 && //medium water
							Convert.ToInt16(cmdViewer.Rows[visTracker].Cells[2].Value) < 170)
					{
						waterImg_Low.Image = waterCircle;
						waterImg_Med.Image = waterCircle;
						waterImg_High.Image = greyCircle;
					}
					else //high water
					{
						waterImg_Low.Image = waterCircle;
						waterImg_Med.Image = waterCircle;
						waterImg_High.Image = waterCircle;
					}

					visTimer.Interval = Convert.ToInt16(cmdViewer.Rows[visTracker].Cells[1].Value); //set the next time interval from list
					visTracker++; //check the next list element
				}
				else
				{
					//when done, reset everything to neutral icon
					timeIndicatorImg.Image = greyCircle;
					waterImg_Low.Image = greyCircle;
					waterImg_Med.Image = greyCircle;
					waterImg_High.Image = greyCircle;

					visTimer.Stop();
					audioPlayer.Ctlcontrols.stop();
					visAudioStarted = false;
				}
			}
		}

		//starts the audio track, caches if necessary
		private void trackStartBtn_Click(object sender, EventArgs e)
		{
			audioPlayer.URL = audioPath;
			audioWatch.Reset();
			audioWatch.Start();
		}

		//pauses the audio, notes the time it stopped
		private void trackStopBtn_Click(object sender, EventArgs e)
		{
			audioPlayer.Ctlcontrols.pause();
			audioWatch.Stop();
			audioCurrentTimeBox.Text = audioWatch.Elapsed.ToString();
		}

		//resumes the audio
		private void audioResumeBtn_Click(object sender, EventArgs e)
		{
			audioWatch.Start();
			audioPlayer.Ctlcontrols.play();
		}

		//loads existing show files into the viewer for editing
		private void loadFileBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog getFileDlg = new OpenFileDialog();
			getFileDlg.FileName = "File";
			getFileDlg.DefaultExt = ".dat";
			getFileDlg.Filter = "Show files (.dat)|*.dat";

			getFileDlg.ShowDialog();

			string filename = getFileDlg.FileName;

			StreamReader reader = new StreamReader(filename);

			totalShowTime = 0;

			cmdViewer.Rows.Clear();

			while ((cmdIncoming = reader.ReadLine()) != null)
			{
				string[] values = cmdIncoming.Split(' ');
				try
				{
					updateTotalTime(Double.Parse(values[0]));
					cmdViewer.Rows.Add(totalShowTime, values[0], values[1], values[2]);
				} catch(FormatException)
				{
					MessageBox.Show("File format is damaged or in incorrect format.");
					break;
				}
			}
			reader.Close();
		}

		//saves everything into the list of whichever fountain is currently there
		//loads up the saved list for fountain 1
		private void switchToList1_Click(object sender, EventArgs e)
		{
			if(currentFountain != 2) //if current fountain is 1, nothing should happen
			{
				cleanupList(currentFountain);
				MessageBox.Show("Cleanup happened");
			} else
			{
				MessageBox.Show("Cleanup didn't happen");
				//do nothing
			}
		}

		private void cleanupList(int fountainIndex)
		{
			switch(fountainIndex)
			{
				case 1:
					currentFtnList = savedFountain1;
					break;
				case 2:
					currentFtnList = savedFountain2;
					break;
				case 3:
					currentFtnList = savedFountain3;
					break;
				case 4:
					currentFtnList = savedFountain4;
					break;
				case 5:
					currentFtnList = savedFountain5;
					break;
				default: //this should never occur!!!
					currentFtnList = savedFountain1;
					break;
			}

			for(int i = 0; i < cmdViewer.RowCount-1; i++) //outer loop grabs the row
			{
				for(int x = 0; x < 4; x++) //inner loop grabs the data and shoves it into list
				{
					currentFtnList[i].Add(cmdViewer.Rows[i].Cells[x].Value.ToString());
				}
			}

			cmdViewer.Rows.Clear();

			MessageBox.Show(currentFtnList[0][1].ToString());
		}


		//takes in the string of color and converts it to an integer number
		private int convertColortoInt(string color)
		{
			int result;

			switch(color)
			{
				case "Red":
					result = 0;
					break;
				case "Green":
					result = 1;
					break;
				case "Blue":
					result = 2;
					break;
				case "Yellow":
					result = 3;
					break;
				default:
					result = -1;
					break;
			}

			return result;
		}
	}
}