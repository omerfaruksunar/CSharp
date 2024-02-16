using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Environment;
using static System.IO.Directory;
using static System.Windows.Forms.Application;
using static System.Windows.Forms.Screen;

namespace ControlsDialogsComponents;

public partial class VtSample : Form
{
	public VtSample()=>InitializeComponent();
	private DataTable _dataTable;
	private BindingSource _bindingSource;

	
}
