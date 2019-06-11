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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.manual_ColorBox = new System.Windows.Forms.ComboBox();
			this.manual_AddBtn = new System.Windows.Forms.Button();
			this.cmdViewer = new System.Windows.Forms.DataGridView();
			this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stopwatchText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.clickTimer = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.manual_TimeBox = new System.Windows.Forms.TextBox();
			this.manual_PowerBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.cmdViewer)).BeginInit();
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
            this.timeColumn,
            this.powerCol,
            this.colorColumn});
			this.cmdViewer.Location = new System.Drawing.Point(809, 12);
			this.cmdViewer.Name = "cmdViewer";
			this.cmdViewer.Size = new System.Drawing.Size(351, 628);
			this.cmdViewer.TabIndex = 13;
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
			this.stopwatchText.Location = new System.Drawing.Point(217, 543);
			this.stopwatchText.Name = "stopwatchText";
			this.stopwatchText.Size = new System.Drawing.Size(47, 20);
			this.stopwatchText.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(173, 527);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 652);
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
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cmdViewer)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn powerCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
		private System.Windows.Forms.TextBox stopwatchText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button clickTimer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox manual_TimeBox;
		private System.Windows.Forms.TextBox manual_PowerBox;
	}
}

