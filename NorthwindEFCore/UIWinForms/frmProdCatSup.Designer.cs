namespace UIWinForms
{
	partial class frmProdCatSup
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
			dgwProdCatSup = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgwProdCatSup).BeginInit();
			SuspendLayout();
			// 
			// dgwProdCatSup
			// 
			dgwProdCatSup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwProdCatSup.Location = new Point(12, 12);
			dgwProdCatSup.Name = "dgwProdCatSup";
			dgwProdCatSup.RowHeadersWidth = 51;
			dgwProdCatSup.Size = new Size(776, 426);
			dgwProdCatSup.TabIndex = 0;
			// 
			// frmProdCatSup
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgwProdCatSup);
			Name = "frmProdCatSup";
			Text = "frmProdCatSup";
			Load += frmProdCatSup_Load;
			((System.ComponentModel.ISupportInitialize)dgwProdCatSup).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgwProdCatSup;
	}
}