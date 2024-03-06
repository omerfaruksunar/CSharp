namespace UIWinForms;
public partial class frmCategories : Form
{
	private readonly Entities.Context.NorthwindContext context;
	private readonly IDalCategory dalCategory;
	public frmCategories()
	{
		InitializeComponent();
		dalCategory = new DalCategory(context = new());
	}

	private void frmCategories_Load(object sender, EventArgs e)
	{
		dgwCategories.DataSource = dalCategory.GetAll().ToList() ;
		dgwCategories.AutoResizeRows();
	}
}
