namespace AsOperator
{
	partial class Form1
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
			cmbItem = new ComboBox();
			btnTemizle = new Button();
			lboxItem = new ListBox();
			txtText = new TextBox();
			rchText = new RichTextBox();
			SuspendLayout();
			// 
			// cmbItem
			// 
			cmbItem.FormattingEnabled = true;
			cmbItem.Location = new Point(0, 0);
			cmbItem.Name = "cmbItem";
			cmbItem.Size = new Size(151, 28);
			cmbItem.TabIndex = 0;
			// 
			// btnTemizle
			// 
			btnTemizle.Location = new Point(188, 12);
			btnTemizle.Name = "btnTemizle";
			btnTemizle.Size = new Size(171, 29);
			btnTemizle.TabIndex = 1;
			btnTemizle.Text = "Yükle";
			btnTemizle.UseVisualStyleBackColor = true;
			btnTemizle.Click += btnTemizle_Click;
			// 
			// lboxItem
			// 
			lboxItem.FormattingEnabled = true;
			lboxItem.Location = new Point(0, 55);
			lboxItem.Name = "lboxItem";
			lboxItem.Size = new Size(150, 104);
			lboxItem.TabIndex = 2;
			// 
			// txtText
			// 
			txtText.Location = new Point(0, 165);
			txtText.Name = "txtText";
			txtText.Size = new Size(125, 27);
			txtText.TabIndex = 3;
			// 
			// rchText
			// 
			rchText.Location = new Point(0, 198);
			rchText.Name = "rchText";
			rchText.Size = new Size(125, 120);
			rchText.TabIndex = 4;
			rchText.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(rchText);
			Controls.Add(txtText);
			Controls.Add(lboxItem);
			Controls.Add(btnTemizle);
			Controls.Add(cmbItem);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbItem;
		private Button btnTemizle;
		private ListBox lboxItem;
		private TextBox txtText;
		private RichTextBox rchText;
	}
}
