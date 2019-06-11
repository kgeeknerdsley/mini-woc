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
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Power ");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Time");
			this.clickTimer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.stopwatchText = new System.Windows.Forms.TextBox();
			this.cmdViewer = new System.Windows.Forms.ListView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.HeaderTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.manualAddToList = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// clickTimer
			// 
			this.clickTimer.Location = new System.Drawing.Point(3, 56);
			this.clickTimer.Name = "clickTimer";
			this.clickTimer.Size = new System.Drawing.Size(155, 113);
			this.clickTimer.TabIndex = 0;
			this.clickTimer.Text = "Timer";
			this.clickTimer.UseVisualStyleBackColor = true;
			this.clickTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickTimer_MouseDown);
			this.clickTimer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clickTimer_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(164, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Time button was held (ms):";
			// 
			// stopwatchText
			// 
			this.stopwatchText.Location = new System.Drawing.Point(180, 72);
			this.stopwatchText.Name = "stopwatchText";
			this.stopwatchText.Size = new System.Drawing.Size(100, 20);
			this.stopwatchText.TabIndex = 2;
			// 
			// cmdViewer
			// 
			this.cmdViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderTest});
			listViewGroup2.Header = "ListViewGroup";
			listViewGroup2.Name = "listViewGroup1";
			this.cmdViewer.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
			this.cmdViewer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
			this.cmdViewer.Location = new System.Drawing.Point(830, 12);
			this.cmdViewer.Name = "cmdViewer";
			this.cmdViewer.Size = new System.Drawing.Size(275, 605);
			this.cmdViewer.TabIndex = 3;
			this.cmdViewer.UseCompatibleStateImageBehavior = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.clickTimer);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.stopwatchText);
			this.panel1.Location = new System.Drawing.Point(12, 418);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(327, 199);
			this.panel1.TabIndex = 4;
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
			this.label3.Location = new System.Drawing.Point(36, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Time (ms) :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Power :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Color: ";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(86, 63);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// HeaderTest
			// 
			this.HeaderTest.Text = "Test Header";
			// 
			// manualAddToList
			// 
			this.manualAddToList.Location = new System.Drawing.Point(253, 35);
			this.manualAddToList.Name = "manualAddToList";
			this.manualAddToList.Size = new System.Drawing.Size(75, 23);
			this.manualAddToList.TabIndex = 11;
			this.manualAddToList.Text = "Add to list";
			this.manualAddToList.UseVisualStyleBackColor = true;
			this.manualAddToList.Click += new System.EventHandler(this.manualAddToList_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 629);
			this.Controls.Add(this.manualAddToList);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cmdViewer);
			this.Name = "Form1";
			this.Text = "Form1";
			//this.Load += new System.EventHandler(this.Form1_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button clickTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox stopwatchText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView cmdViewer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ColumnHeader HeaderTest;
		private System.Windows.Forms.Button manualAddToList;
	}
}

