using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace NackademinUppgift05.UI
{
	public partial class HomePage : Form
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadAnimals();
		}

		private void LoadAnimals()
		{
			animalsListBox.Items.Clear();

			using (var zoo = new ZoophobiaContainer())
			{
				animalsListBox.Items.AddRange(zoo.Animals
					.Include(a => a.Parents)
					.Include(a => a.Species)
					.ToArray());
			}
		}

		private void animalCreateButton_Click(object sender, System.EventArgs e)
		{
			new AnimalPage().ShowDialog();
			LoadAnimals();
		}
	}
}
