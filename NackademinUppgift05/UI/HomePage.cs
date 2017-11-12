using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using NackademinUppgift05.Migrations;

namespace NackademinUppgift05.UI
{
	public partial class HomePage : Form
	{
		public readonly ZoophobiaContainer zoo;

		public HomePage()
		{
			zoo = new ZoophobiaContainer();
			InitializeComponent();
		}

		~HomePage()
		{
			zoo?.Dispose();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Configuration.MySeedBecauseModelFirstMessesMeUp(zoo);
			zoo.SaveChanges();
			

			LoadAnimals();
		}

		private bool SearchQuery(Animal animal)
		{
			string search = animalSearchTextBox.Text.Trim().ToLower();

			return
				// Search name
				animal.Name.ToLower().Contains(search)
				// Search environment
				|| animal.Species.Environment.Label.ToLower().Contains(search)
				// Search eater type
				|| animal.Species.EaterType.Label.ToLower().Contains(search)
				// Search species
				|| animal.Species.Label.ToLower().Contains(search)
			;
		}

		private void LoadAnimals()
		{
			animalsListBox.Items.Clear();

			Animal[] results = zoo.Animals
				.Include("Species")
				.Include("Species.Environment")
				.Include("Species.EaterType")
				.Include("AnimalParents")
				.Where(SearchQuery)
				.ToArray();

			animalsListBox.Items.AddRange(results);

			bool any = animalsListBox.Items.Count > 0;
			animalsListBox.Enabled = any;
			if (!any)
			{
				animalsListBox.Items.Add("<No animals matches your query>");
			}
		}

		private void animalCreateButton_Click(object sender, System.EventArgs e)
		{
			new AnimalPage(zoo).ShowDialog();
			LoadAnimals();
		}

		private void animalsListBox_DoubleClick(object sender, System.EventArgs e)
		{
			if (!(animalsListBox.SelectedItem is Animal animal))
				return;

			new AnimalPage(zoo, animal).ShowDialog();
			LoadAnimals();
		}

		private void animalDeleteButton_Click(object sender, System.EventArgs e)
		{
			if (!(animalsListBox.SelectedItem is Animal animal))
				return;

			zoo.Animals.Remove(animal);
			zoo.SaveChanges();
			LoadAnimals();
		}

		private void animalSearchButton_Click(object sender, System.EventArgs e)
		{
			LoadAnimals();
		}
	}
}
