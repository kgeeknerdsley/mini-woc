namespace mwoc_programmer
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.manual_ColorBox = new System.Windows.Forms.ComboBox();
			this.manual_AddBtn = new System.Windows.Forms.Button();
			this.cmdViewer = new System.Windows.Forms.DataGridView();
			this.totalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stopwatchText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.clickTimer = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.manual_TimeBox = new System.Windows.Forms.TextBox();
			this.manual_PowerBox = new System.Windows.Forms.TextBox();
			this.outputToFileBtn = new System.Windows.Forms.Button();
			this.patternBtnBox = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.patternColorBox = new System.Windows.Forms.ComboBox();
			this.patternPowerBox = new System.Windows.Forms.TextBox();
			this.patternListBtn = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.gradTimeBox = new System.Windows.Forms.TextBox();
			this.gradRiseRBtn = new System.Windows.Forms.RadioButton();
			this.gradFallRBtn = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.gradPowerBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pumpImage = new System.Windows.Forms.PictureBox();
			this.waterImg_Low = new System.Windows.Forms.PictureBox();
			this.waterImg_Med = new System.Windows.Forms.PictureBox();
			this.waterImg_High = new System.Windows.Forms.PictureBox();
			this.visualizerPanel = new System.Windows.Forms.Panel();
			this.timeIndicatorImg = new System.Windows.Forms.PictureBox();
			this.pumpColorImg = new System.Windows.Forms.PictureBox();
			this.startVisualizerBtn = new System.Windows.Forms.Button();
			this.trackStartBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.audioResumeBtn = new System.Windows.Forms.Button();
			this.audioCurrentTimeBox = new System.Windows.Forms.TextBox();
			this.trackStopBtn = new System.Windows.Forms.Button();
			this.audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.loadFileBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.cmdViewer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pumpImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.waterImg_Low)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.waterImg_Med)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.waterImg_High)).BeginInit();
			this.visualizerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeIndicatorImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pumpColorImg)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Manual Programmer";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Time (ms) :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Power :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Color: ";
			// 
			// manual_ColorBox
			// 
			this.manual_ColorBox.FormattingEnabled = true;
			this.manual_ColorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow"});
			this.manual_ColorBox.Location = new System.Drawing.Point(100, 81);
			this.manual_ColorBox.Name = "manual_ColorBox";
			this.manual_ColorBox.Size = new System.Drawing.Size(58, 21);
			this.manual_ColorBox.TabIndex = 10;
			// 
			// manual_AddBtn
			// 
			this.manual_AddBtn.Location = new System.Drawing.Point(176, 48);
			this.manual_AddBtn.Name = "manual_AddBtn";
			this.manual_AddBtn.Size = new System.Drawing.Size(75, 23);
			this.manual_AddBtn.TabIndex = 11;
			this.manual_AddBtn.Text = "Add to list";
			this.manual_AddBtn.UseVisualStyleBackColor = true;
			this.manual_AddBtn.Click += new System.EventHandler(this.manualAddToList_Click);
			// 
			// cmdViewer
			// 
			this.cmdViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.cmdViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cmdViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalTimeColumn,
            this.timeColumn,
            this.powerCol,
            this.colorColumn});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.cmdViewer.DefaultCellStyle = dataGridViewCellStyle6;
			this.cmdViewer.Location = new System.Drawing.Point(874, 12);
			this.cmdViewer.Name = "cmdViewer";
			this.cmdViewer.Size = new System.Drawing.Size(286, 565);
			this.cmdViewer.TabIndex = 13;
			// 
			// totalTimeColumn
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			this.totalTimeColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.totalTimeColumn.HeaderText = "Total Time";
			this.totalTimeColumn.Name = "totalTimeColumn";
			this.totalTimeColumn.ToolTipText = "Total show time in seconds";
			// 
			// timeColumn
			// 
			this.timeColumn.HeaderText = "Time";
			this.timeColumn.Name = "timeColumn";
			// 
			// powerCol
			// 
			this.powerCol.HeaderText = "Power";
			this.powerCol.Name = "powerCol";
			// 
			// colorColumn
			// 
			this.colorColumn.HeaderText = "Color";
			this.colorColumn.Name = "colorColumn";
			// 
			// stopwatchText
			// 
			this.stopwatchText.Location = new System.Drawing.Point(217, 580);
			this.stopwatchText.Name = "stopwatchText";
			this.stopwatchText.Size = new System.Drawing.Size(47, 20);
			this.stopwatchText.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(173, 564);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Time button was held (ms):";
			// 
			// clickTimer
			// 
			this.clickTimer.Location = new System.Drawing.Point(12, 527);
			this.clickTimer.Name = "clickTimer";
			this.clickTimer.Size = new System.Drawing.Size(155, 113);
			this.clickTimer.TabIndex = 0;
			this.clickTimer.Text = "Timer";
			this.clickTimer.UseVisualStyleBackColor = true;
			this.clickTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickTimer_MouseDown);
			this.clickTimer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickTimer_MouseUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 502);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Stopwatch";
			// 
			// manual_TimeBox
			// 
			this.manual_TimeBox.Location = new System.Drawing.Point(100, 29);
			this.manual_TimeBox.Name = "manual_TimeBox";
			this.manual_TimeBox.Size = new System.Drawing.Size(34, 20);
			this.manual_TimeBox.TabIndex = 15;
			// 
			// manual_PowerBox
			// 
			this.manual_PowerBox.Location = new System.Drawing.Point(100, 55);
			this.manual_PowerBox.Name = "manual_PowerBox";
			this.manual_PowerBox.Size = new System.Drawing.Size(34, 20);
			this.manual_PowerBox.TabIndex = 16;
			// 
			// outputToFileBtn
			// 
			this.outputToFileBtn.Location = new System.Drawing.Point(874, 583);
			this.outputToFileBtn.Name = "outputToFileBtn";
			this.outputToFileBtn.Size = new System.Drawing.Size(286, 27);
			this.outputToFileBtn.TabIndex = 17;
			this.outputToFileBtn.Text = "Output show to file";
			this.outputToFileBtn.UseVisualStyleBackColor = true;
			this.outputToFileBtn.Click += new System.EventHandler(this.outputToFileBtn_Click);
			// 
			// patternBtnBox
			// 
			this.patternBtnBox.Location = new System.Drawing.Point(12, 173);
			this.patternBtnBox.Name = "patternBtnBox";
			this.patternBtnBox.Size = new System.Drawing.Size(128, 100);
			this.patternBtnBox.TabIndex = 18;
			this.patternBtnBox.Text = "Tap out pattern";
			this.patternBtnBox.UseVisualStyleBackColor = true;
			this.patternBtnBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patternBtn_MouseDown);
			this.patternBtnBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.patternBtn_MouseUp);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Pattern Generator";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(146, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Power:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(149, 202);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Color:";
			// 
			// patternColorBox
			// 
			this.patternColorBox.FormattingEnabled = true;
			this.patternColorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow"});
			this.patternColorBox.Location = new System.Drawing.Point(189, 202);
			this.patternColorBox.Name = "patternColorBox";
			this.patternColorBox.Size = new System.Drawing.Size(58, 21);
			this.patternColorBox.TabIndex = 22;
			// 
			// patternPowerBox
			// 
			this.patternPowerBox.Location = new System.Drawing.Point(189, 173);
			this.patternPowerBox.Name = "patternPowerBox";
			this.patternPowerBox.Size = new System.Drawing.Size(58, 20);
			this.patternPowerBox.TabIndex = 23;
			// 
			// patternListBtn
			// 
			this.patternListBtn.Location = new System.Drawing.Point(152, 238);
			this.patternListBtn.Name = "patternListBtn";
			this.patternListBtn.Size = new System.Drawing.Size(95, 35);
			this.patternListBtn.TabIndex = 24;
			this.patternListBtn.Text = "Add to list";
			this.patternListBtn.UseVisualStyleBackColor = true;
			this.patternListBtn.Click += new System.EventHandler(this.patternListBtn_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 298);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "Gradual Rise/Fall";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(39, 315);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 13);
			this.label11.TabIndex = 26;
			this.label11.Text = "Time (ms): ";
			// 
			// gradTimeBox
			// 
			this.gradTimeBox.Location = new System.Drawing.Point(100, 315);
			this.gradTimeBox.Name = "gradTimeBox";
			this.gradTimeBox.Size = new System.Drawing.Size(34, 20);
			this.gradTimeBox.TabIndex = 27;
			// 
			// gradRiseRBtn
			// 
			this.gradRiseRBtn.AutoSize = true;
			this.gradRiseRBtn.Checked = true;
			this.gradRiseRBtn.Location = new System.Drawing.Point(33, 340);
			this.gradRiseRBtn.Name = "gradRiseRBtn";
			this.gradRiseRBtn.Size = new System.Drawing.Size(46, 17);
			this.gradRiseRBtn.TabIndex = 29;
			this.gradRiseRBtn.TabStop = true;
			this.gradRiseRBtn.Text = "Rise";
			this.gradRiseRBtn.UseVisualStyleBackColor = true;
			// 
			// gradFallRBtn
			// 
			this.gradFallRBtn.AutoSize = true;
			this.gradFallRBtn.Location = new System.Drawing.Point(88, 341);
			this.gradFallRBtn.Name = "gradFallRBtn";
			this.gradFallRBtn.Size = new System.Drawing.Size(41, 17);
			this.gradFallRBtn.TabIndex = 30;
			this.gradFallRBtn.TabStop = true;
			this.gradFallRBtn.Text = "Fall";
			this.gradFallRBtn.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(28, 361);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(66, 13);
			this.label12.TabIndex = 31;
			this.label12.Text = "Max Power: ";
			// 
			// gradPowerBox
			// 
			this.gradPowerBox.Location = new System.Drawing.Point(100, 361);
			this.gradPowerBox.Name = "gradPowerBox";
			this.gradPowerBox.Size = new System.Drawing.Size(47, 20);
			this.gradPowerBox.TabIndex = 32;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(35, 389);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(44, 13);
			this.label13.TabIndex = 33;
			this.label13.Text = "Speed: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 389);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(33, 20);
			this.textBox1.TabIndex = 34;
			// 
			// pumpImage
			// 
			this.pumpImage.Image = ((System.Drawing.Image)(resources.GetObject("pumpImage.Image")));
			this.pumpImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pumpImage.InitialImage")));
			this.pumpImage.Location = new System.Drawing.Point(58, 135);
			this.pumpImage.Name = "pumpImage";
			this.pumpImage.Size = new System.Drawing.Size(80, 61);
			this.pumpImage.TabIndex = 35;
			this.pumpImage.TabStop = false;
			// 
			// waterImg_Low
			// 
			this.waterImg_Low.Image = ((System.Drawing.Image)(resources.GetObject("waterImg_Low.Image")));
			this.waterImg_Low.Location = new System.Drawing.Point(58, 90);
			this.waterImg_Low.Name = "waterImg_Low";
			this.waterImg_Low.Size = new System.Drawing.Size(25, 25);
			this.waterImg_Low.TabIndex = 36;
			this.waterImg_Low.TabStop = false;
			// 
			// waterImg_Med
			// 
			this.waterImg_Med.Image = ((System.Drawing.Image)(resources.GetObject("waterImg_Med.Image")));
			this.waterImg_Med.Location = new System.Drawing.Point(58, 59);
			this.waterImg_Med.Name = "waterImg_Med";
			this.waterImg_Med.Size = new System.Drawing.Size(25, 25);
			this.waterImg_Med.TabIndex = 37;
			this.waterImg_Med.TabStop = false;
			// 
			// waterImg_High
			// 
			this.waterImg_High.Image = ((System.Drawing.Image)(resources.GetObject("waterImg_High.Image")));
			this.waterImg_High.Location = new System.Drawing.Point(58, 28);
			this.waterImg_High.Name = "waterImg_High";
			this.waterImg_High.Size = new System.Drawing.Size(25, 25);
			this.waterImg_High.TabIndex = 38;
			this.waterImg_High.TabStop = false;
			// 
			// visualizerPanel
			// 
			this.visualizerPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.visualizerPanel.Controls.Add(this.timeIndicatorImg);
			this.visualizerPanel.Controls.Add(this.pumpColorImg);
			this.visualizerPanel.Controls.Add(this.pumpImage);
			this.visualizerPanel.Controls.Add(this.waterImg_Low);
			this.visualizerPanel.Controls.Add(this.waterImg_Med);
			this.visualizerPanel.Controls.Add(this.waterImg_High);
			this.visualizerPanel.Cursor = System.Windows.Forms.Cursors.Default;
			this.visualizerPanel.Location = new System.Drawing.Point(598, 404);
			this.visualizerPanel.Name = "visualizerPanel";
			this.visualizerPanel.Size = new System.Drawing.Size(200, 202);
			this.visualizerPanel.TabIndex = 39;
			// 
			// timeIndicatorImg
			// 
			this.timeIndicatorImg.Image = ((System.Drawing.Image)(resources.GetObject("timeIndicatorImg.Image")));
			this.timeIndicatorImg.Location = new System.Drawing.Point(155, 14);
			this.timeIndicatorImg.Name = "timeIndicatorImg";
			this.timeIndicatorImg.Size = new System.Drawing.Size(25, 25);
			this.timeIndicatorImg.TabIndex = 40;
			this.timeIndicatorImg.TabStop = false;
			// 
			// pumpColorImg
			// 
			this.pumpColorImg.Image = ((System.Drawing.Image)(resources.GetObject("pumpColorImg.Image")));
			this.pumpColorImg.Location = new System.Drawing.Point(155, 157);
			this.pumpColorImg.Name = "pumpColorImg";
			this.pumpColorImg.Size = new System.Drawing.Size(25, 25);
			this.pumpColorImg.TabIndex = 39;
			this.pumpColorImg.TabStop = false;
			// 
			// startVisualizerBtn
			// 
			this.startVisualizerBtn.Location = new System.Drawing.Point(598, 613);
			this.startVisualizerBtn.Name = "startVisualizerBtn";
			this.startVisualizerBtn.Size = new System.Drawing.Size(200, 27);
			this.startVisualizerBtn.TabIndex = 40;
			this.startVisualizerBtn.Text = "Start Visualizer";
			this.startVisualizerBtn.UseVisualStyleBackColor = true;
			this.startVisualizerBtn.Click += new System.EventHandler(this.startVisualizerBtn_Click);
			// 
			// trackStartBtn
			// 
			this.trackStartBtn.Location = new System.Drawing.Point(70, 72);
			this.trackStartBtn.Name = "trackStartBtn";
			this.trackStartBtn.Size = new System.Drawing.Size(104, 23);
			this.trackStartBtn.TabIndex = 41;
			this.trackStartBtn.Text = "Play Audio";
			this.trackStartBtn.UseVisualStyleBackColor = true;
			this.trackStartBtn.Click += new System.EventHandler(this.trackStartBtn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.audioResumeBtn);
			this.panel1.Controls.Add(this.audioCurrentTimeBox);
			this.panel1.Controls.Add(this.trackStopBtn);
			this.panel1.Controls.Add(this.audioPlayer);
			this.panel1.Controls.Add(this.trackStartBtn);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Location = new System.Drawing.Point(581, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(244, 369);
			this.panel1.TabIndex = 43;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(19, 168);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(73, 13);
			this.label14.TabIndex = 50;
			this.label14.Text = "Current Time: ";
			// 
			// audioResumeBtn
			// 
			this.audioResumeBtn.Location = new System.Drawing.Point(70, 130);
			this.audioResumeBtn.Name = "audioResumeBtn";
			this.audioResumeBtn.Size = new System.Drawing.Size(104, 23);
			this.audioResumeBtn.TabIndex = 45;
			this.audioResumeBtn.Text = "Resume Audio";
			this.audioResumeBtn.UseVisualStyleBackColor = true;
			this.audioResumeBtn.Click += new System.EventHandler(this.audioResumeBtn_Click);
			// 
			// audioCurrentTimeBox
			// 
			this.audioCurrentTimeBox.Location = new System.Drawing.Point(119, 162);
			this.audioCurrentTimeBox.Name = "audioCurrentTimeBox";
			this.audioCurrentTimeBox.Size = new System.Drawing.Size(112, 20);
			this.audioCurrentTimeBox.TabIndex = 44;
			this.audioCurrentTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// trackStopBtn
			// 
			this.trackStopBtn.Location = new System.Drawing.Point(70, 101);
			this.trackStopBtn.Name = "trackStopBtn";
			this.trackStopBtn.Size = new System.Drawing.Size(104, 23);
			this.trackStopBtn.TabIndex = 43;
			this.trackStopBtn.Text = "Pause Audio";
			this.trackStopBtn.UseVisualStyleBackColor = true;
			this.trackStopBtn.Click += new System.EventHandler(this.trackStopBtn_Click);
			// 
			// audioPlayer
			// 
			this.audioPlayer.Enabled = true;
			this.audioPlayer.Location = new System.Drawing.Point(17, 3);
			this.audioPlayer.Name = "audioPlayer";
			this.audioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audioPlayer.OcxState")));
			this.audioPlayer.Size = new System.Drawing.Size(212, 65);
			this.audioPlayer.TabIndex = 42;
			// 
			// loadFileBtn
			// 
			this.loadFileBtn.Location = new System.Drawing.Point(874, 616);
			this.loadFileBtn.Name = "loadFileBtn";
			this.loadFileBtn.Size = new System.Drawing.Size(286, 27);
			this.loadFileBtn.TabIndex = 44;
			this.loadFileBtn.Text = "Load File";
			this.loadFileBtn.UseVisualStyleBackColor = true;
			this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 652);
			this.Controls.Add(this.loadFileBtn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.startVisualizerBtn);
			this.Controls.Add(this.visualizerPanel);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.gradPowerBox);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.gradFallRBtn);
			this.Controls.Add(this.gradRiseRBtn);
			this.Controls.Add(this.gradTimeBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.patternListBtn);
			this.Controls.Add(this.patternPowerBox);
			this.Controls.Add(this.patternColorBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.patternBtnBox);
			this.Controls.Add(this.outputToFileBtn);
			this.Controls.Add(this.manual_PowerBox);
			this.Controls.Add(this.manual_TimeBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.clickTimer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdViewer);
			this.Controls.Add(this.stopwatchText);
			this.Controls.Add(this.manual_AddBtn);
			this.Controls.Add(this.manual_ColorBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Mini WoC Programmer";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cmdViewer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pumpImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.waterImg_Low)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.waterImg_Med)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.waterImg_High)).EndInit();
			this.visualizerPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeIndicatorImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pumpColorImg)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox manual_ColorBox;
		private System.Windows.Forms.Button manual_AddBtn;
		private System.Windows.Forms.DataGridView cmdViewer;
		private System.Windows.Forms.TextBox stopwatchText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button clickTimer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox manual_TimeBox;
		private System.Windows.Forms.TextBox manual_PowerBox;
		private System.Windows.Forms.Button outputToFileBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn powerCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
		private System.Windows.Forms.Button patternBtnBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox patternColorBox;
		private System.Windows.Forms.TextBox patternPowerBox;
		private System.Windows.Forms.Button patternListBtn;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox gradTimeBox;
		private System.Windows.Forms.RadioButton gradRiseRBtn;
		private System.Windows.Forms.RadioButton gradFallRBtn;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox gradPowerBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pumpImage;
		private System.Windows.Forms.PictureBox waterImg_Low;
		private System.Windows.Forms.PictureBox waterImg_Med;
		private System.Windows.Forms.PictureBox waterImg_High;
		private System.Windows.Forms.Panel visualizerPanel;
		private System.Windows.Forms.PictureBox pumpColorImg;
		private System.Windows.Forms.Button startVisualizerBtn;
		private System.Windows.Forms.PictureBox timeIndicatorImg;
		private System.Windows.Forms.Button trackStartBtn;
		private System.Windows.Forms.Panel panel1;
		private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
		private System.Windows.Forms.TextBox audioCurrentTimeBox;
		private System.Windows.Forms.Button trackStopBtn;
		private System.Windows.Forms.Button audioResumeBtn;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button loadFileBtn;
	}
}

