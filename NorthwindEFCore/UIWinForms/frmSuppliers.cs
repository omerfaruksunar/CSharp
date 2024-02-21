namespace UIWinForms;
public partial class frmSuppliers: Form
{
    private readonly NorthwindContext context;
    private readonly DalSupplier dalSupplier;
    private frmProduct frm = new();
    public frmSuppliers()
    {
        InitializeComponent();
        dalSupplier = new(context = new());
    }
    private void frmSuppliers_Load(object sender, EventArgs e)
    {
        dgwSuppliers.DataSource = dalSupplier.GetAll().ToList();
        dgwSuppliers.AutoResizeRows();
    }
}