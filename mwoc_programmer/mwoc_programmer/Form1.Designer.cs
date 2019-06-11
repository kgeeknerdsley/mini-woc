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
			this.clickTimer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.stopwatchText = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.manualAddToList = new System.Windows.Forms.Button();
			this.cmdViewer = new System.Windows.Forms.DataGridView();
			this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmdViewer)).BeginInit();
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 652);
			this.Controls.Add(this.cmdViewer);
			this.Controls.Add(this.manualAddToList);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmdViewer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button clickTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox stopwatchText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button manualAddToList;
		private System.Windows.Forms.DataGridView cmdViewer;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn powerCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
	}
}

