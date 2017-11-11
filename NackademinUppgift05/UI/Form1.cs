using System.Linq;
using System.Windows.Forms;
using NackademinUppgift05.DAL;

namespace NackademinUppgift05.UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			using (var zoo = new Zoophobia())
			{
				dataGridView1.DataSource = zoo.Environments.ToList();
			}
		}
	}
}
