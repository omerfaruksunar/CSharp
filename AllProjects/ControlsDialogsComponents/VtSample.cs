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
	public VtSample() => InitializeComponent();
	private DataTable _dataTable;
	private BindingSource _bindingSource;
	private DataGridView _dataGridView;
	private NotifyIcon _notifyIcon;
	private ToolStripComboBox _toolStripComboFilter, _toolStripComboBox;
	private ToolStripStatusLabel _toolStripStatusLabel, _toolStripLabel;
	private int _yukseklik;
	private StatusStrip _statusStrip;
	private BindingNavigator _bindingNavigator;

	private void VtSample_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Normal;
		FormBorderStyle = FormBorderStyle.FixedSingle;
		Left = Top = 0;
		Size = PrimaryScreen.WorkingArea.Size; //primary screen static using static System.Windows.Forms.Screen; �zerinden calisir
		_yukseklik = Size.Height;
		ShowInTaskbar = false; // Form'un gorev cubugunda gozukmemesi icin
		AutoScroll = true;
		SqlConnectionStringBuilder builder = new();
		string BilgisayarAdi = ".";
		builder.DataSource = BilgisayarAdi;
		builder.InitialCatalog = "Northwind";
		builder.UserID = "sa";
		builder.Password = "123";
		using SqlConnection sqlConnection
			= new SqlConnection(builder.ToString());
		using SqlDataAdapter sqlDataAdapter = new
		("Select * From Products", sqlConnection);
		_dataTable = new();
		try
		{
			DataSet dataSet = new();
			_dataTable.TableName = "1.Tablom";
			dataSet.Tables.Add(_dataTable);
			sqlDataAdapter.Fill(dataSet.Tables["1. Tablom"]);
		}
		catch (Exception ex)
		{
			throw new Exception(
				$"Server Ad�: {builder["Server"]} veya " +
				$"\nDatabase Ad�: {builder["Database"]} ya da " +
				$"\nBa�lant� Adapt�r�: {typeof(SqlDataAdapter)} hatal� " +
				$"\nveya olas� di�er hatalar {ex.Message}");
		}
		SplitContainer splitContainer = new(); //B�l�c�
		splitContainer.Orientation = Orientation.Horizontal; //B�lme islemini yatayda yapacak
		splitContainer.Dock = DockStyle.Fill;
		Controls.Add(splitContainer);
		_bindingNavigator = new(true); //Formda gezme �zelligi
		_bindingSource = new();
		_bindingSource.DataSource = _dataTable;
		_bindingNavigator.BindingSource = _bindingSource;
		_bindingNavigator.DeleteItem.Enabled = false;
		_bindingNavigator.AddNewItem.Enabled = false;
		splitContainer.SplitterDistance = _bindingNavigator.Height;
		splitContainer.Panel1.Controls.Add(_bindingNavigator);
		_dataGridView = new();
		_dataGridView.AllowDrop = _dataGridView.AllowUserToAddRows = false;//AllowDrop : Tasima ozelligi / AllowUserToAddRows : Yeni satir ekleme ozelligi
		_dataGridView.AllowUserToDeleteRows = false;
		_dataGridView.SelectionMode =
			DataGridViewSelectionMode.FullRowSelect; // Bir satir sectigimde tum satir secilsin
		_dataGridView.AutoResizeColumns(); // Sutunlar otomatik boyutlans�n
		_dataGridView.AutoSizeColumnsMode = 
			DataGridViewAutoSizeColumnsMode.DisplayedCells;
		_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
		_dataGridView.DataSource = _bindingSource;
		_dataGridView.Dock = DockStyle.Fill;
		_dataGridView.ColumnHeadersVisible = true;
		splitContainer.Panel2.Controls.Add(_dataGridView);
		DataGridViewRowColor(_dataGridView); //satirlari renklendirir
		_dataGridView.DataBindingComplete +=
			DataGridView_DataBindingComplete;
		_statusStrip = new();
		_toolStripStatusLabel = new();
		_toolStripLabel = new();
		ToolStripButton toolStripButton = new();
		ToolStripSplitButton toolStripSplitButton = new();
		ToolStripSplitButton splitButtonPrint = new();
		_toolStripComboFilter = new();
		_toolStripComboBox = new();
		_statusStrip.Items.Add(_toolStripStatusLabel);
		ToolStripSeparator toolStripSeparator = new();
		_statusStrip.Items.Add(toolStripSeparator);
		_statusStrip.Items.Add(_toolStripLabel);
		_statusStrip.Items.Add(_toolStripComboBox);
		ToolStripComboBoxFill(_toolStripComboBox, out int gridGenislik);
		_toolStripComboBox.SelectedIndexChanged += 
			ToolStripComboBox_SelectedIndexChanged;
		_statusStrip.Items.Add(_toolStripComboFilter);
		_statusStrip.Items.Add(toolStripButton);
		toolStripButton.Click += ToolStripButton_Click;
		toolStripButton.Text = "Filtrele";
		//projenin baslangic yolu, Ekledigimiz fotograflara ulasmak icin bu tanimlamayi yaptik.
		string directoryInfo = //StarupPath ise appl�cation sinifina ait o da static
			//parent parent parent olma sebebi dosya yolundan eksilterek ilerlememiz cd.. gibi.
			GetParent(StartupPath).Parent.Parent.Parent.FullName; //Get parent directory info s�n�f�na ait static bir s�n�foldugu icin yukar�da tan�mlad�k.
		toolStripSplitButton.Image=
			Image.FromFile(directoryInfo+ "\\Chart.png");
		toolStripSplitButton.Click += ToolStripSplitButton_Click;
		_statusStrip.Items.Add(toolStripSplitButton);
		splitButtonPrint.Image =
			Image.FromFile(directoryInfo + "\\printer.png");
			splitButtonPrint.Click += splitButtonPrint_Click;
		_statusStrip.Items.Add(splitButtonPrint);
		Controls.Add(_statusStrip);

		Width = gridGenislik + 96;
		LabelWriter();
		Icon sysIcon = SystemIcons.Information;
		Icon icon = new(sysIcon, 50, 50);
		_notifyIcon = new NotifyIcon
		{
			Icon = icon,
			BalloonTipTitle = (string)builder["Database"],
			BalloonTipIcon = ToolTipIcon.Info,
			Text = sqlDataAdapter.SelectCommand.CommandText,
			Visible = true
		};
		FormClosing += VtSample_FormClosing;
	}

	private void DataGridViewRowColor(DataGridView dataGridView)
	{
		dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
		dataGridView.AlternatingRowsDefaultCellStyle.
			BackColor = Color.GhostWhite;
	}

	private void DataGridView_DataBindingComplete
		(object sender, DataGridViewBindingCompleteEventArgs e)
		=> LabelWriter();

	private void ToolStripComboBoxFill(ToolStripComboBox toolStripComboBox,
		out int gridGenislik)
	{
		string _bicim = string.Empty;
		int genislik = 0;
		for (int j = 0; j < _dataGridView.Columns.Count; j++)
		{
			var dataGridViewColumn = _dataGridView.Columns[j];
			var dbTblColumn = _dataTable.Columns[j];
			dataGridViewColumn.DefaultCellStyle.Alignment =
				DataGridViewContentAlignment.MiddleRight;
			if (dbTblColumn.DataType == typeof(short) ||
					dbTblColumn.DataType == typeof(double) ||
					dbTblColumn.DataType == typeof(decimal))
			{
				_bicim = "N2";
			}
			else if (dbTblColumn.DataType == typeof(int))
			{
				_bicim = "N0";
			}
			else
			{
				dataGridViewColumn.DefaultCellStyle.Alignment =
					DataGridViewContentAlignment.MiddleLeft;
			}
			dataGridViewColumn.DefaultCellStyle.Format = _bicim;
			genislik += dataGridViewColumn.Width;
			toolStripComboBox.Items.Add(
				_dataTable.Columns[j].ColumnName);
		}
		gridGenislik = genislik;
	}

	private void ToolStripComboBox_SelectedIndexChanged
		(object sender, EventArgs e)
	{
		var columnName =((ToolStripComboBox)sender).Text;
		DataColumn dataColumn = _dataTable.Columns[columnName];
		ControlsClear(_toolStripComboFilter);
		_toolStripComboFilter.Sorted = true;
		foreach(DataRow item in _dataTable.Rows)
		{
			if (!_toolStripComboFilter.Items.Contains(item[dataColumn]))
			{
				_toolStripComboFilter.Items.Add(item[dataColumn]);
			}
		}
	}

	//Birden fazla parametre gonderebildigimiz 
	private void ControlsClear(params dynamic[]? controls)
	{
		if (controls == null) return;
		try
		{
			foreach (dynamic ctrl in controls)
			{
				ctrl.Text = string.Empty;
				ctrl.Items.Clear();
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
		}
	}

	private bool _tiklandi=false;
	private void ToolStripButton_Click(object sender, EventArgs e)
	{
		if (_toolStripComboFilter.Items.Count == 0 ||
			_toolStripComboFilter.Text == string.Empty) return;
		_notifyIcon.Visible = true;
		_tiklandi = !_tiklandi;
		if(!_tiklandi )
		{
			((ToolStripButton)sender).Text = "Filtrele";
			_dataTable.DefaultView.RowFilter = null;
			DataGridViewRowColor(_dataGridView);
			Height = _yukseklik;
			return;
		}
		//String bir deger gonderdigimizde like ile arama yap�yoruz 
		((ToolStripButton)sender).Text = @"T�m�n� G�ster";
		DataGridViewRowColor(_dataGridView);
		try
		{
			_dataTable.DefaultView.RowFilter = _ =
				$"{_toolStripComboBox.Text} LIKE " +
				$"'%{_toolStripComboFilter.Text}%'";
		}
		catch (Exception)
		{
			if (_toolStripComboFilter.Text == string.Empty) return;
			string aranan =
				_toolStripComboFilter.Text.Replace(',','.');
			_dataTable.DefaultView.RowFilter =
				string.Format($"{_toolStripComboBox?.Text}= {aranan}");
		}
	}
	private int satir;
	private double toplamStokFiltreli;
	private void LabelWriter()
	{
		ControlsClear(_toolStripStatusLabel);
		var toplamStok = _dataTable
			.Compute("Sum(UnitsInStock)", "true");
		_toolStripStatusLabel.Text =
			$@"Toplam Stok: {toplamStok:0,00} adet";
		satir = _dataGridView.Rows.GetRowCount
			(DataGridViewElementStates.Visible);
		_toolStripLabel.Text = $@"{satir} sat�r =>";
		//cast = d�k�m
		toplamStokFiltreli = _dataGridView.Rows.Cast<DataGridViewRow>()
			.Sum(x =>
			Convert.ToDouble(x.Cells["UnitsInStock"].Value));
		_toolStripLabel.Text +=
			$@"Filtreye G�re Toplam Stok: {toplamStokFiltreli} =>";
		double toplamSiparis = _dataGridView.Rows.Cast<DataGridViewRow>().Sum(x =>
			Convert.ToDouble(x.Cells["UnitsOnOrder"].Value));
		_toolStripLabel.Text += $@"ve Sipari� Adedi : {toplamSiparis}";
	}

	private void ToolStripSplitButton_Click(object sender, EventArgs e )
	{
		//chart => �izelge
		using Form chartForm = new();
		chartForm.AutoSize = true;
		chartForm.WindowState = FormWindowState.Normal;
		chartForm.FormBorderStyle = FormBorderStyle.FixedSingle;
		chartForm.Left = chartForm.Top = 0;
		chartForm.Size = PrimaryScreen.WorkingArea.Size;
		chartForm.ShowInTaskbar = true;
		chartForm.AutoScroll = true;
		Chart chart = new(); //Tum grafigi cizmek icin chart kullaniyoruz.
		chart.Size = chartForm.Size;
		Title title = new();
		title.Text = "Fiyat ve Stok Durumu";
		chart.Titles.Add(title);
		string axisX = _dataTable.Columns["ProductName"]!.Caption;
		string axisY = _dataTable.Columns["UnitPrice"]!.Caption;
		ChartArea chartArea = new(); //Grafigin icindeki nesneler icin ChartArea kullaniyoruz.
		chartArea.AxisX.Interval = 1;
		chartArea.AxisY.Interval = 10;
		chartArea.AxisX.Title = axisX;
		chartArea.AxisY.Title = axisY;
		Font font = new("Arial",14,FontStyle.Bold);
		title.Font =
			chartArea.AxisX.TitleFont =
			chartArea.AxisY.TitleFont =
			chartArea.AxisX.LabelStyle.Font=
			chartArea.AxisY.LabelStyle.Font = font;
		chartArea.Area3DStyle.Enable3D = true;
		chartArea.Area3DStyle.LightStyle = LightStyle.Simplistic;
		chartArea.Area3DStyle.Rotation = 10;
		chartArea.Area3DStyle.WallWidth = 25;
		chartArea.Area3DStyle.Inclination = 40;
		chart.ChartAreas.Add(chartArea);
		Series series = new();
		series.ChartType = SeriesChartType.Column;
		series.SetCustomProperty
			("DrawingStyle", "Cylinder");
		series.SetCustomProperty("LabelStyle", "Top");
		series.IsValueShownAsLabel = true;
		series.XValueMember = _dataGridView
			.Columns[axisX]?.DataPropertyName;
		series.YValueMembers=_dataGridView
			.Columns[axisY]?.DataPropertyName;
		chart.Series.Add(series);
		chart.SaveImage("Chart.bmp", ChartImageFormat.Bmp);
		chart.AntiAliasing = AntiAliasingStyles.All;
		chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;
		chart.DataSource = _dataGridView.DataSource;
		chartForm.Controls.Add(chart); //add yada addrange kullanmadan ram
		ChartColorFormat(chart, series, chartArea);
		chartForm.ShowDialog();
	}
	PrintDocument printDocument;
	private Bitmap bitmap;
	private static void ChartColorFormat 
		(Chart chart, Series series, ChartArea chartArea)
	{
		chart.BackColor = chartArea.BackColor = Color.FloralWhite;
		chartArea.AxisX.MajorGrid.LineColor =
			chartArea.AxisY.MajorGrid.LineColor = Color.Black;
		chart.BackSecondaryColor =
			series.BackSecondaryColor =
				Color.LightGoldenrodYellow;
		chart.BackGradientStyle =
			chartArea.BackGradientStyle =
				series.BackGradientStyle = GradientStyle.VerticalCenter;
		series.Palette = ChartColorPalette.Pastel;
	}

	private void splitButtonPrint_Click(object? sender, EventArgs e)
	{
		printDocument = new();
		printDocument.PrintPage += PrintDocument_PrintPage;
		PrintDialog printDialog = new();
		printDialog.Document = printDocument;
		printDialog.UseEXDialog = true;
		bitmap=new Bitmap(_dataGridView.Width, _dataGridView.Height);
		_dataGridView.DrawToBitmap
			(bitmap,new Rectangle(20,20,
			_dataGridView.Width, _dataGridView.Height));
		DialogResult result=printDialog.ShowDialog();
		if (result == DialogResult.OK)
		{
			printDocument.DocumentName = MachineName;
			printDocument.DefaultPageSettings.Landscape = true;
			printDocument.Print();
		}
	}

	private void PrintDocument_PrintPage (object sender, PrintPageEventArgs e)
		=>e.Graphics?.DrawImage(bitmap, 0, 0);

	private void VtSample_FormClosing
		(object sender, FormClosingEventArgs e)
						=> _notifyIcon.Dispose();
}
