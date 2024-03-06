namespace UIWinForms;
public partial class frmSuppliers: Form
{
    private readonly Entities.Context.NorthwindContext context;
    private readonly IDalSupplier dalSupplier;
    private frmProduct frm = new();
    public frmSuppliers()
    {
        InitializeComponent();
        dalSupplier = new DalSupplier(context = new());
    }
    private void frmSuppliers_Load(object sender, EventArgs e)
    {
        dgwSuppliers.DataSource = dalSupplier.GetAll().ToList();
        dgwSuppliers.AutoResizeRows();
    }
}