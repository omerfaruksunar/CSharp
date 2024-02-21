using Entities.Models;
using Microsoft.EntityFrameworkCore;
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
		dgwProducts.DataSource = ProductIncludeData();
		DgwFormat(dgwProducts);
		dgwProductCatName.DataSource =
			dalPrdCatName.GetProductsCatName().ToList();
		DgwFormat(dgwProductCatName);
		CmbCatLoad();
		CmbSupLoad();
	}

	private List<Product> ProductIncludeData()
		=> dalProduct.GetAll()
					  .Include(x => x.Category)
					  .Include(x => x.Supplier).ToList();
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
		foreach (DataGridView item in dgw.Rows)
		{
			item. = satirNo.ToString();
			satirNo++;
			if (satirNo > 500) break;
		}
		dgw.RowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
		dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
	}
}
