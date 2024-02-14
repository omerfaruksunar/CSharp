namespace WeekDays
{
	partial class Ornek2
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lstBoxWeekDays = new ListBox();
			SuspendLayout();
			// 
			// lstBoxWeekDays
			// 
			lstBoxWeekDays.FormattingEnabled = true;
			lstBoxWeekDays.Location = new Point(12, 12);
			lstBoxWeekDays.Name = "lstBoxWeekDays";
			lstBoxWeekDays.Size = new Size(150, 104);
			lstBoxWeekDays.TabIndex = 0;
			// 
			// Ornek2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lstBoxWeekDays);
			Name = "Ornek2";
			Text = "Haftanın Günleri";
			Load += Ornek2_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListBox lstBoxWeekDays;
	}
}
