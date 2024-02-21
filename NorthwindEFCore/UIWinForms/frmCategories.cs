namespace UIWinForms;
public partial class frmCategories : Form
{
	private readonly NorthwindContext context;
	private readonly DalCategory dalCategory;
	public frmCategories()
	{
		InitializeComponent();
		dalCategory = new(context = new());
	}

	private void frmCategories_Load(object sender, EventArgs e)
	{
		dgwCategories.DataSource = dalCategory.GetAll().ToList() ;
		dgwCategories.AutoResizeRows();
	}
}
