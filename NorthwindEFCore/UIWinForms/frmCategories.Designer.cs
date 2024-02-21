namespace UIWinForms
{
	partial class frmCategories
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
			dgwCategories = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgwCategories).BeginInit();
			SuspendLayout();
			// 
			// dgwCategories
			// 
			dgwCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwCategories.Location = new Point(12, 12);
			dgwCategories.Name = "dgwCategories";
			dgwCategories.RowHeadersWidth = 51;
			dgwCategories.Size = new Size(588, 426);
			dgwCategories.TabIndex = 0;
			// 
			// frmCategories
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(608, 450);
			Controls.Add(dgwCategories);
			Name = "frmCategories";
			Text = "frmCategories";
			Load += frmCategories_Load;
			((System.ComponentModel.ISupportInitialize)dgwCategories).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgwCategories;
	}
}