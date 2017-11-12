using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using NackademinUppgift05.Migrations;

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
			using (var zoo = new ZoophobiaContainer())
			{
				Configuration.MySeedBecauseModelFirstMessesMeUp(zoo);
				zoo.SaveChanges();
			}

			LoadAnimals();
		}

		private void LoadAnimals()
		{
			animalsListBox.Items.Clear();

			using (var zoo = new ZoophobiaContainer())
			{
				animalsListBox.Items.AddRange(zoo.Animals
					.Include(a => a.AnimalParents)
					.Include(a => a.Species)
					.Include(a => a.AnimalParents)
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
