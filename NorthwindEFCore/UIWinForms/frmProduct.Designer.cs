namespace UIWinForms
{
	partial class frmProduct
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
			dgwProductCatName = new DataGridView();
			grbUrunler = new GroupBox();
			btnDTO = new Button();
			btnSupplier = new Button();
			btnYeni = new Button();
			rdbDiscontinued = new RadioButton();
			txtReorderLevel = new TextBox();
			lblReorder = new Label();
			lblCategoryId = new Label();
			cmbCategoryID = new ComboBox();
			txtProductId = new TextBox();
			lblProductId = new Label();
			lblSupplierId = new Label();
			cmbSupplierID = new ComboBox();
			btnGuncelle = new Button();
			btnSil = new Button();
			btnEkle = new Button();
			txtUnitsInStock = new TextBox();
			txtQuantityPerUnit = new TextBox();
			lblStock = new Label();
			lblPerUnit = new Label();
			txtUnitsOnOrder = new TextBox();
			lblUnitsOrder = new Label();
			txtUnitPrice = new TextBox();
			lblPrice = new Label();
			txtProductName = new TextBox();
			lblProductName = new Label();
			grbProduct = new GroupBox();
			btnTumu = new Button();
			txtAra = new TextBox();
			lblUrunAra = new Label();
			dgwProducts = new DataGridView();
			grbCategories = new GroupBox();
			btnCategories = new Button();
			lblKategoriler = new Label();
			cmbCategories = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgwProductCatName).BeginInit();
			grbUrunler.SuspendLayout();
			grbProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
			grbCategories.SuspendLayout();
			SuspendLayout();
			// 
			// dgwProductCatName
			// 
			dgwProductCatName.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgwProductCatName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwProductCatName.Location = new Point(1, 597);
			dgwProductCatName.Margin = new Padding(5, 4, 5, 4);
			dgwProductCatName.Name = "dgwProductCatName";
			dgwProductCatName.RowHeadersWidth = 51;
			dgwProductCatName.RowTemplate.Height = 25;
			dgwProductCatName.Size = new Size(493, 428);
			dgwProductCatName.TabIndex = 31;
			// 
			// grbUrunler
			// 
			grbUrunler.BackColor = SystemColors.GradientInactiveCaption;
			grbUrunler.Controls.Add(btnDTO);
			grbUrunler.Controls.Add(btnSupplier);
			grbUrunler.Controls.Add(btnYeni);
			grbUrunler.Controls.Add(rdbDiscontinued);
			grbUrunler.Controls.Add(txtReorderLevel);
			grbUrunler.Controls.Add(lblReorder);
			grbUrunler.Controls.Add(lblCategoryId);
			grbUrunler.Controls.Add(cmbCategoryID);
			grbUrunler.Controls.Add(txtProductId);
			grbUrunler.Controls.Add(lblProductId);
			grbUrunler.Controls.Add(lblSupplierId);
			grbUrunler.Controls.Add(cmbSupplierID);
			grbUrunler.Controls.Add(btnGuncelle);
			grbUrunler.Controls.Add(btnSil);
			grbUrunler.Controls.Add(btnEkle);
			grbUrunler.Controls.Add(txtUnitsInStock);
			grbUrunler.Controls.Add(txtQuantityPerUnit);
			grbUrunler.Controls.Add(lblStock);
			grbUrunler.Controls.Add(lblPerUnit);
			grbUrunler.Controls.Add(txtUnitsOnOrder);
			grbUrunler.Controls.Add(lblUnitsOrder);
			grbUrunler.Controls.Add(txtUnitPrice);
			grbUrunler.Controls.Add(lblPrice);
			grbUrunler.Controls.Add(txtProductName);
			grbUrunler.Controls.Add(lblProductName);
			grbUrunler.Location = new Point(309, 9);
			grbUrunler.Margin = new Padding(5, 4, 5, 4);
			grbUrunler.Name = "grbUrunler";
			grbUrunler.Padding = new Padding(5, 4, 5, 4);
			grbUrunler.Size = new Size(1035, 192);
			grbUrunler.TabIndex = 29;
			grbUrunler.TabStop = false;
			grbUrunler.Text = "Ürünler";
			// 
			// btnDTO
			// 
			btnDTO.BackColor = SystemColors.GradientActiveCaption;
			btnDTO.Location = new Point(906, 113);
			btnDTO.Margin = new Padding(5, 4, 5, 4);
			btnDTO.Name = "btnDTO";
			btnDTO.Size = new Size(101, 36);
			btnDTO.TabIndex = 22;
			btnDTO.Text = "View DTO";
			btnDTO.UseVisualStyleBackColor = false;
			btnDTO.Click += btnDTO_Click;
			// 
			// btnSupplier
			// 
			btnSupplier.BackColor = SystemColors.GradientActiveCaption;
			btnSupplier.Location = new Point(91, 147);
			btnSupplier.Margin = new Padding(5, 4, 5, 4);
			btnSupplier.Name = "btnSupplier";
			btnSupplier.Size = new Size(46, 31);
			btnSupplier.TabIndex = 21;
			btnSupplier.Text = "Aç";
			btnSupplier.UseVisualStyleBackColor = false;
			btnSupplier.Click += btnSupplier_Click;
			// 
			// btnYeni
			// 
			btnYeni.BackColor = SystemColors.GradientActiveCaption;
			btnYeni.Location = new Point(13, 25);
			btnYeni.Margin = new Padding(5, 4, 5, 4);
			btnYeni.Name = "btnYeni";
			btnYeni.Size = new Size(101, 36);
			btnYeni.TabIndex = 19;
			btnYeni.Text = "Yeni";
			btnYeni.UseVisualStyleBackColor = false;
			btnYeni.Click += btnYeni_Click;
			// 
			// rdbDiscontinued
			// 
			rdbDiscontinued.AutoSize = true;
			rdbDiscontinued.ImageAlign = ContentAlignment.BottomCenter;
			rdbDiscontinued.Location = new Point(909, 78);
			rdbDiscontinued.Margin = new Padding(5, 4, 5, 4);
			rdbDiscontinued.Name = "rdbDiscontinued";
			rdbDiscontinued.Size = new Size(117, 24);
			rdbDiscontinued.TabIndex = 18;
			rdbDiscontinued.TabStop = true;
			rdbDiscontinued.Text = "Discontinued";
			rdbDiscontinued.UseVisualStyleBackColor = true;
			// 
			// txtReorderLevel
			// 
			txtReorderLevel.Location = new Point(736, 148);
			txtReorderLevel.Margin = new Padding(5, 4, 5, 4);
			txtReorderLevel.Name = "txtReorderLevel";
			txtReorderLevel.Size = new Size(147, 27);
			txtReorderLevel.TabIndex = 10;
			// 
			// lblReorder
			// 
			lblReorder.AutoSize = true;
			lblReorder.Location = new Point(611, 158);
			lblReorder.Margin = new Padding(5, 0, 5, 0);
			lblReorder.Name = "lblReorder";
			lblReorder.Size = new Size(103, 20);
			lblReorder.TabIndex = 15;
			lblReorder.Text = "Reorder Level:";
			// 
			// lblCategoryId
			// 
			lblCategoryId.AutoSize = true;
			lblCategoryId.Location = new Point(304, 81);
			lblCategoryId.Margin = new Padding(5, 0, 5, 0);
			lblCategoryId.Name = "lblCategoryId";
			lblCategoryId.Size = new Size(91, 20);
			lblCategoryId.TabIndex = 14;
			lblCategoryId.Text = "Category ID:";
			// 
			// cmbCategoryID
			// 
			cmbCategoryID.FormattingEnabled = true;
			cmbCategoryID.Location = new Point(434, 76);
			cmbCategoryID.Margin = new Padding(5, 4, 5, 4);
			cmbCategoryID.Name = "cmbCategoryID";
			cmbCategoryID.Size = new Size(147, 28);
			cmbCategoryID.TabIndex = 5;
			// 
			// txtProductId
			// 
			txtProductId.Enabled = false;
			txtProductId.Location = new Point(145, 76);
			txtProductId.Margin = new Padding(5, 4, 5, 4);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(147, 27);
			txtProductId.TabIndex = 2;
			// 
			// lblProductId
			// 
			lblProductId.AutoSize = true;
			lblProductId.Location = new Point(9, 86);
			lblProductId.Margin = new Padding(5, 0, 5, 0);
			lblProductId.Name = "lblProductId";
			lblProductId.Size = new Size(80, 20);
			lblProductId.TabIndex = 11;
			lblProductId.Text = "Product Id:";
			// 
			// lblSupplierId
			// 
			lblSupplierId.AutoSize = true;
			lblSupplierId.Location = new Point(9, 152);
			lblSupplierId.Margin = new Padding(5, 0, 5, 0);
			lblSupplierId.Name = "lblSupplierId";
			lblSupplierId.Size = new Size(86, 20);
			lblSupplierId.TabIndex = 10;
			lblSupplierId.Text = "Supplier ID:";
			// 
			// cmbSupplierID
			// 
			cmbSupplierID.FormattingEnabled = true;
			cmbSupplierID.Location = new Point(145, 147);
			cmbSupplierID.Margin = new Padding(5, 4, 5, 4);
			cmbSupplierID.Name = "cmbSupplierID";
			cmbSupplierID.Size = new Size(147, 28);
			cmbSupplierID.TabIndex = 4;
			// 
			// btnGuncelle
			// 
			btnGuncelle.BackColor = SystemColors.GradientActiveCaption;
			btnGuncelle.Location = new Point(232, 25);
			btnGuncelle.Margin = new Padding(5, 4, 5, 4);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(101, 36);
			btnGuncelle.TabIndex = 13;
			btnGuncelle.Text = "Güncelle";
			btnGuncelle.UseVisualStyleBackColor = false;
			btnGuncelle.Click += btnGuncelle_Click;
			//btnGuncelle.MouseEnter += btnGuncelle_MouseEnter;
			btnGuncelle.MouseMove += btnGuncelle_MouseMove;
			// 
			// btnSil
			// 
			btnSil.BackColor = SystemColors.GradientActiveCaption;
			btnSil.Location = new Point(343, 25);
			btnSil.Margin = new Padding(5, 4, 5, 4);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(101, 36);
			btnSil.TabIndex = 14;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click;
			//btnSil.MouseEnter += btnSil_MouseEnter;
			btnSil.MouseMove += btnSil_MouseMove;
			// 
			// btnEkle
			// 
			btnEkle.BackColor = SystemColors.GradientActiveCaption;
			btnEkle.Location = new Point(121, 25);
			btnEkle.Margin = new Padding(5, 4, 5, 4);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(101, 36);
			btnEkle.TabIndex = 12;
			btnEkle.Text = "Ekle";
			btnEkle.UseVisualStyleBackColor = false;
			btnEkle.Click += btnEkle_Click;
			//btnEkle.MouseEnter += btnEkle_MouseEnter;
			btnEkle.MouseMove += btnEkle_MouseMove;
			// 
			// txtUnitsInStock
			// 
			txtUnitsInStock.Location = new Point(736, 76);
			txtUnitsInStock.Margin = new Padding(5, 4, 5, 4);
			txtUnitsInStock.Name = "txtUnitsInStock";
			txtUnitsInStock.Size = new Size(147, 27);
			txtUnitsInStock.TabIndex = 8;
			// 
			// txtQuantityPerUnit
			// 
			txtQuantityPerUnit.Location = new Point(434, 112);
			txtQuantityPerUnit.Margin = new Padding(5, 4, 5, 4);
			txtQuantityPerUnit.Name = "txtQuantityPerUnit";
			txtQuantityPerUnit.Size = new Size(147, 27);
			txtQuantityPerUnit.TabIndex = 6;
			// 
			// lblStock
			// 
			lblStock.AutoSize = true;
			lblStock.Location = new Point(611, 81);
			lblStock.Margin = new Padding(5, 0, 5, 0);
			lblStock.Name = "lblStock";
			lblStock.Size = new Size(101, 20);
			lblStock.TabIndex = 3;
			lblStock.Text = "Units In Stock:";
			// 
			// lblPerUnit
			// 
			lblPerUnit.AutoSize = true;
			lblPerUnit.Location = new Point(304, 118);
			lblPerUnit.Margin = new Padding(5, 0, 5, 0);
			lblPerUnit.Name = "lblPerUnit";
			lblPerUnit.Size = new Size(123, 20);
			lblPerUnit.TabIndex = 3;
			lblPerUnit.Text = "Quantity Per Unit:";
			// 
			// txtUnitsOnOrder
			// 
			txtUnitsOnOrder.Location = new Point(736, 112);
			txtUnitsOnOrder.Margin = new Padding(5, 4, 5, 4);
			txtUnitsOnOrder.Name = "txtUnitsOnOrder";
			txtUnitsOnOrder.Size = new Size(147, 27);
			txtUnitsOnOrder.TabIndex = 9;
			// 
			// lblUnitsOrder
			// 
			lblUnitsOrder.AutoSize = true;
			lblUnitsOrder.Location = new Point(611, 122);
			lblUnitsOrder.Margin = new Padding(5, 0, 5, 0);
			lblUnitsOrder.Name = "lblUnitsOrder";
			lblUnitsOrder.Size = new Size(110, 20);
			lblUnitsOrder.TabIndex = 1;
			lblUnitsOrder.Text = "Units On Order:";
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(434, 148);
			txtUnitPrice.Margin = new Padding(5, 4, 5, 4);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(147, 27);
			txtUnitPrice.TabIndex = 7;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Location = new Point(304, 152);
			lblPrice.Margin = new Padding(5, 0, 5, 0);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(75, 20);
			lblPrice.TabIndex = 1;
			lblPrice.Text = "Unit Price:";
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(145, 112);
			txtProductName.Margin = new Padding(5, 4, 5, 4);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(147, 27);
			txtProductName.TabIndex = 3;
			// 
			// lblProductName
			// 
			lblProductName.AutoSize = true;
			lblProductName.Location = new Point(9, 118);
			lblProductName.Margin = new Padding(5, 0, 5, 0);
			lblProductName.Name = "lblProductName";
			lblProductName.Size = new Size(107, 20);
			lblProductName.TabIndex = 1;
			lblProductName.Text = "Product Name:";
			// 
			// grbProduct
			// 
			grbProduct.Controls.Add(btnTumu);
			grbProduct.Controls.Add(txtAra);
			grbProduct.Controls.Add(lblUrunAra);
			grbProduct.Location = new Point(10, 101);
			grbProduct.Margin = new Padding(5, 4, 5, 4);
			grbProduct.Name = "grbProduct";
			grbProduct.Padding = new Padding(5, 4, 5, 4);
			grbProduct.Size = new Size(289, 100);
			grbProduct.TabIndex = 28;
			grbProduct.TabStop = false;
			grbProduct.Text = "Ürünler";
			// 
			// btnTumu
			// 
			btnTumu.BackColor = SystemColors.GradientActiveCaption;
			btnTumu.Location = new Point(97, 56);
			btnTumu.Margin = new Padding(5, 4, 5, 4);
			btnTumu.Name = "btnTumu";
			btnTumu.Size = new Size(149, 36);
			btnTumu.TabIndex = 2;
			btnTumu.Text = "Tümünü Görüntüle";
			btnTumu.UseVisualStyleBackColor = false;
			btnTumu.Click += btnTumu_Click;
			// 
			// txtAra
			// 
			txtAra.Location = new Point(97, 24);
			txtAra.Margin = new Padding(5, 4, 5, 4);
			txtAra.Name = "txtAra";
			txtAra.Size = new Size(147, 27);
			txtAra.TabIndex = 1;
			txtAra.TextChanged += txtAra_TextChanged;
			// 
			// lblUrunAra
			// 
			lblUrunAra.AutoSize = true;
			lblUrunAra.Location = new Point(20, 30);
			lblUrunAra.Margin = new Padding(5, 0, 5, 0);
			lblUrunAra.Name = "lblUrunAra";
			lblUrunAra.Size = new Size(70, 20);
			lblUrunAra.TabIndex = 1;
			lblUrunAra.Text = "Ürün Ara:";
			// 
			// dgwProducts
			// 
			dgwProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwProducts.Location = new Point(1, 209);
			dgwProducts.Margin = new Padding(5, 4, 5, 4);
			dgwProducts.Name = "dgwProducts";
			dgwProducts.RowHeadersWidth = 51;
			dgwProducts.RowTemplate.Height = 25;
			dgwProducts.Size = new Size(1334, 380);
			dgwProducts.TabIndex = 30;
			dgwProducts.CellClick += dgwProducts_CellClick;
			// 
			// grbCategories
			// 
			grbCategories.Controls.Add(btnCategories);
			grbCategories.Controls.Add(lblKategoriler);
			grbCategories.Controls.Add(cmbCategories);
			grbCategories.Location = new Point(10, 8);
			grbCategories.Margin = new Padding(5, 4, 5, 4);
			grbCategories.Name = "grbCategories";
			grbCategories.Padding = new Padding(5, 4, 5, 4);
			grbCategories.Size = new Size(289, 84);
			grbCategories.TabIndex = 27;
			grbCategories.TabStop = false;
			grbCategories.Text = "Kategoriler";
			// 
			// btnCategories
			// 
			btnCategories.BackColor = SystemColors.GradientActiveCaption;
			btnCategories.Location = new Point(103, 29);
			btnCategories.Margin = new Padding(5, 4, 5, 4);
			btnCategories.Name = "btnCategories";
			btnCategories.Size = new Size(46, 31);
			btnCategories.TabIndex = 20;
			btnCategories.Text = "Aç";
			btnCategories.UseVisualStyleBackColor = false;
			btnCategories.Click += btnCategories_Click;
			// 
			// lblKategoriler
			// 
			lblKategoriler.AutoSize = true;
			lblKategoriler.Location = new Point(20, 34);
			lblKategoriler.Margin = new Padding(5, 0, 5, 0);
			lblKategoriler.Name = "lblKategoriler";
			lblKategoriler.Size = new Size(86, 20);
			lblKategoriler.TabIndex = 1;
			lblKategoriler.Text = "Kategoriler:";
			// 
			// cmbCategories
			// 
			cmbCategories.FormattingEnabled = true;
			cmbCategories.Location = new Point(151, 29);
			cmbCategories.Margin = new Padding(5, 4, 5, 4);
			cmbCategories.Name = "cmbCategories";
			cmbCategories.Size = new Size(138, 28);
			cmbCategories.TabIndex = 0;
			cmbCategories.SelectionChangeCommitted += cmbCategories_SelectionChangeCommitted;
			// 
			// frmProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1348, 595);
			Controls.Add(dgwProductCatName);
			Controls.Add(grbUrunler);
			Controls.Add(grbProduct);
			Controls.Add(dgwProducts);
			Controls.Add(grbCategories);
			Name = "frmProduct";
			Text = "Ürün Listesi";
			Load += frmProduct_Load;
			((System.ComponentModel.ISupportInitialize)dgwProductCatName).EndInit();
			grbUrunler.ResumeLayout(false);
			grbUrunler.PerformLayout();
			grbProduct.ResumeLayout(false);
			grbProduct.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
			grbCategories.ResumeLayout(false);
			grbCategories.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgwProductCatName;
		private GroupBox grbUrunler;
		private Button btnDTO;
		private Button btnSupplier;
		private Button btnYeni;
		private RadioButton rdbDiscontinued;
		private TextBox txtReorderLevel;
		private Label lblReorder;
		private Label lblCategoryId;
		private ComboBox cmbCategoryID;
		private TextBox txtProductId;
		private Label lblProductId;
		private Label lblSupplierId;
		private ComboBox cmbSupplierID;
		private Button btnGuncelle;
		private Button btnSil;
		private Button btnEkle;
		private TextBox txtUnitsInStock;
		private TextBox txtQuantityPerUnit;
		private Label lblStock;
		private Label lblPerUnit;
		private TextBox txtUnitsOnOrder;
		private Label lblUnitsOrder;
		private TextBox txtUnitPrice;
		private Label lblPrice;
		private TextBox txtProductName;
		private Label lblProductName;
		private GroupBox grbProduct;
		private Button btnTumu;
		private TextBox txtAra;
		private Label lblUrunAra;
		private DataGridView dgwProducts;
		private GroupBox grbCategories;
		private Button btnCategories;
		private Label lblKategoriler;
		private ComboBox cmbCategories;
	}
}