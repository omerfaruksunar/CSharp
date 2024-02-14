namespace OrnekForm1;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}
	private string[] iller = { "Ýstanbul", "Sakarya", "Ankara", "Ýzmir", "Bursa" };
	private void Form1_Load(object sender, EventArgs e)
	{
		comboBox1.Items.AddRange(iller);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		comboBox1.Items.Clear();
		Array.Sort(iller);
		comboBox1.Items.AddRange(iller);
		MessageBox.Show(iller[0]);
	}
}
