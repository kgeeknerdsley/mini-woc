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
			this.cmdViewer = new System.Windows.Forms.ListView();
			this.panel1 = new System.Windows.Forms.Panel();
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 629);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cmdViewer);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button clickTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox stopwatchText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView cmdViewer;
	}
}

