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

		private void LoadAnimals()
		{
			animalsListBox.Items.Clear();
			
			animalsListBox.Items.AddRange(zoo.Animals
				.Include(a => a.Species)
				.Include(a => a.AnimalParents)
				.ToArray());
			
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
	}
}
