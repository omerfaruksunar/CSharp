using Entities.Models;
using Microsoft.EntityFrameworkCore;
using static System.Convert;
namespace UIWinForms;
public partial class frmProduct : Form
{
	private readonly NorthwindContext context;
	private readonly DalCategory dalCategory;
	private readonly DalProduct dalProduct;
	private readonly DalSupplier dalSupplier;
	private readonly DalDtoProductCatName dalPrdCatName;
	public frmProduct()
	{
		context = new();
		dalProduct = new DalProduct(context);
		dalCategory = new DalCategory(context);
		dalSupplier = new DalSupplier(context);
		dalPrdCatName = new DalDtoProductCatName(context);
		InitializeComponent();
	}

	private void frmProduct_Load(object sender, EventArgs e)
	{
		dgwProducts.DataSource = ProductIncludeData().ToList();
		DgwFormat(dgwProducts);
		dgwProductCatName.DataSource = dalPrdCatName.GetProductsCatName(0).ToList();
		DgwFormat(dgwProductCatName);
		CmbCatLoad();
		CmbSupLoad();

	}

	private IQueryable<Product> ProductIncludeData()
		=> dalProduct.GetAll()
					  .Include(x => x.Category)
					  .Include(x => x.Supplier);
	private void CmbCatLoad()
	{
		cmbCategoryID.DataSource = dalCategory.GetAll().ToList();
		cmbCategories.DataSource = dalCategory.GetAll().ToList();
		cmbCategories.DisplayMember = nameof(Category.CategoryName);
		cmbCategoryID.DisplayMember = nameof(Category.CategoryName);
		cmbCategories.ValueMember = nameof(Category.CategoryId);
		cmbCategoryID.ValueMember = nameof(Category.CategoryId);
	}
	private void CmbSupLoad()
	{
		cmbSupplierID.DataSource = dalSupplier.GetAll().ToList();
		cmbSupplierID.DisplayMember = nameof(Supplier.CompanyName);
		cmbSupplierID.ValueMember = nameof(Supplier.SupplierId);
	}
	private void btnCategories_Click(object sender, EventArgs e)
	{
		var frmOpen = new frmCategories();
		frmOpen.ShowDialog();
	}

	private void btnSupplier_Click(object sender, EventArgs e)
	{
		var frmOpen = new frmSuppliers();
		frmOpen.ShowDialog();
	}

	private void btnDTO_Click(object sender, EventArgs e)
	{
		var frmOpen = new frmProdCatSup();
		frmOpen.ShowDialog();
	}
	public void DgwFormat(DataGridView dgw)
	{
		int satirNo = 1;
		foreach (DataGridViewRow item in dgw.Rows)
		{
			item.HeaderCell.Value = satirNo.ToString();
			satirNo++;
			if (satirNo > 500) break;
		}
		dgw.AutoResizeRowHeadersWidth
			(DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader);
		dgw.RowsDefaultCellStyle.BackColor = Color.White;
		dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
		dgw.EditMode = DataGridViewEditMode.EditProgrammatically;
		dgw.AllowUserToDeleteRows = false;
		dgw.AllowUserToAddRows = false;
		//Satirlara göre olsun
		dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
		dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		
	}

	private void cmbCategories_SelectionChangeCommitted(object sender, EventArgs e)
	{
		//cmb'nin combobox'ı ifade edebilmesi için yazdık.
		var cmb = sender as ComboBox;
		var isCatID = int.TryParse(cmb.SelectedValue.ToString(),
			out var catID);
		if (isCatID)
		{
			dgwProducts.DataSource = dalPrdCatName.GetProductsByCategory(catID).ToList();
			DgwFormat(dgwProducts);
		}
	}
	int satir = 0;
	private void btnTumu_Click(object sender, EventArgs e)
	{
		if (dgwProducts.CurrentRow?.Cells?.Count > 0)
		{
			satir = dgwProducts.CurrentRow.Cells[0].RowIndex > 1
													? dgwProducts.CurrentRow.Cells[0].RowIndex
													: dgwProducts.RowCount - 1;
		}
		dgwProducts.DataSource = ProductIncludeData().ToList();
		DgwFormat(dgwProducts);
		txtAra.Clear();
		dgwProducts.CurrentCell = dgwProducts.Rows[satir].Cells[1];
	}

	private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		GridToControl(sender);
	}
	private void GridToControl(object sender)
	{
		var row = (sender as DataGridView).CurrentRow;
		txtProductId.Text = row.Cells[0].Value.ToString();
		txtProductName.Text = row.Cells[1].Value.ToString();
		cmbSupplierID.SelectedValue = row.Cells[2].Value;
		cmbCategoryID.SelectedValue = row.Cells[3].Value;
		txtQuantityPerUnit.Text = row.Cells[4].Value.ToString();
		txtUnitPrice.Text = row.Cells[5].Value.ToString();
		txtUnitsInStock.Text = row.Cells[6].Value.ToString();
		txtUnitsOnOrder.Text = row.Cells[7].Value.ToString();
		txtReorderLevel.Text = row.Cells[8].Value.ToString();
		//System static convert
		rdbDiscontinued.Checked = ToBoolean(row.Cells[9].Value);
	}

	private void txtAra_TextChanged(object sender, EventArgs e)
	{
		if (sender is TextBox txt)
			dgwProducts.DataSource =
					string.IsNullOrWhiteSpace(txt.Text)
					? ProductIncludeData().ToList()
					: ProductIncludeData().Where(x => x.ProductName
					.Contains(txtAra.Text)).ToList();
	}

	private void btnYeni_Click(object sender, EventArgs e)
				=> txtProductId.Text = "";

	private async void btnEkle_Click(object sender, EventArgs e)
	{
		var prd = new Product();
		await CUDEntity(CUDType.Insert, prd);
		DgwFormat(dgwProducts);
		MessageBox.Show($"{prd} eklendi");
		btnTumu_Click(null, null);
	}
	private async void btnGuncelle_Click(object sender, EventArgs e)
	{
		var prd = new Product();
		await CUDEntity(CUDType.Update, prd);
		DgwFormat(dgwProducts);
		MessageBox.Show($"{prd} Guncellendi");
		btnTumu_Click(null, null);
	}
	private async void btnSil_Click(object sender, EventArgs e)
	{
		var prd = new Product();
		await CUDEntity(CUDType.Delete, prd);
		DgwFormat(dgwProducts);
		MessageBox.Show($"{prd} Silindi");
		satir--;
		btnTumu_Click(null, null);

	}
	private async Task CUDEntity(CUDType cruType, Product prd)
	{
		prd.ProductId = cruType == CUDType.Insert ? 0
			: ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
		prd.ProductName = txtProductName.Text;
		prd.SupplierId = ToInt32(cmbSupplierID.SelectedValue);
		prd.CategoryId = ToInt32(cmbCategoryID.SelectedValue);
		prd.QuantityPerUnit = txtQuantityPerUnit.Text;
		prd.UnitPrice = ToDecimal(txtUnitPrice.Text);
		prd.UnitsInStock = ToInt16(txtUnitsInStock.Text);
		prd.UnitsOnOrder = ToInt16(txtUnitsOnOrder.Text);
		prd.ReorderLevel = ToInt16(txtReorderLevel.Text);
		prd.Discontinued = rdbDiscontinued.Checked;
		switch (cruType)
		{
			case CUDType.Insert:
				await dalProduct.AddAsync(prd);
				break;
			case CUDType.Update:
				await dalProduct.UpdateAsync(prd);
				break;
			case CUDType.Delete:
				await dalProduct.RemoveAsync(prd);
				break;
			default:
				break;
		}
	}

	private void btnEkle_MouseMove(object sender, MouseEventArgs e)
												=> CUDControl(sender);


	private void btnGuncelle_MouseMove(object sender, MouseEventArgs e)
												=> CUDControl(sender);



	private void btnSil_MouseMove(object sender, MouseEventArgs e)
												=> CUDControl(sender);

	/*private void btnEkle_MouseEnter(object sender, EventArgs e)
													=> CUDControl(sender);

	private void btnGuncelle_MouseEnter(object sender, EventArgs e)
													=> CUDControl(sender);


	private void btnSil_MouseEnter(object sender, EventArgs e)
													=> CUDControl(sender);*/

	private void CUDControl(object sender)
	{
		var button = (Button)sender;
		btnEkle.Enabled = true;
		btnYeni.Enabled = true;
		btnSil.Enabled = true;
		btnGuncelle.Enabled = true;
		if (txtProductId.Text != "" && button == btnEkle)
		{
			MessageBox.Show(
				$"""
				Bu ürün zaten mevcuttur, ancak güncelleme 
				veya silme işlemi yapabilirsiniz!
				""");
		}
		else if (txtProductId.Text == "" && button != btnEkle)
		{
			string delUp = button == btnSil ? "Sil" : "Güncelle";
			MessageBox.Show(
				$"""
				Grid üzerinden bir ürün seçmediniz.
				Hangi ürün {delUp}me işlemine tabi tutulacak seçmeniz gerekir.
				"""
				);
		}
	}

	public enum CUDType
	{
		Insert, Update, Delete
	}
}
