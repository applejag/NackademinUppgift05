using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackademinUppgift05.UI
{
	public partial class SpeciesPage : Form
	{
		public SpeciesPage()
		{
			InitializeComponent();
		}

		private void LoadSpecies()
		{
			speciesEnvironmentComboBox.Items.Clear();
			speciesEaterTypeComboBox.Items.Clear();
			speciesListBox.Items.Clear();

			using (var zoo = new ZoophobiaContainer())
			{
				speciesEnvironmentComboBox.Items.AddRange(zoo.Environments
					.ToArray());
				speciesEaterTypeComboBox.Items.AddRange(zoo.EaterTypes
					.ToArray());
				speciesListBox.Items.AddRange(zoo.Species
					.Include(s => s.EaterType)
					.Include(s => s.Environment)
					.ToArray());
			}
		}

		private void SpeciesPage_Load(object sender, EventArgs e)
		{
			LoadSpecies();
		}

		private void speciesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			speciesDeleteButton.Enabled = speciesListBox.SelectedItem != null;
		}

		private void speciesDeleteButton_Click(object sender, EventArgs e)
		{
			if (!(speciesListBox.SelectedItem is Species species))
				return;

			using (var zoo = new ZoophobiaContainer())
			{
				speciesListBox.Items.Remove(species);
				zoo.Species.Remove(species);
				zoo.SaveChanges();
			}
		}

		private void speciesCreateButton_Click(object sender, EventArgs e)
		{
			if (!(speciesEaterTypeComboBox.SelectedItem is EaterType eaterType))
				return;

			if (!(speciesEnvironmentComboBox.SelectedItem is Environment environment))
				return;

			if (string.IsNullOrWhiteSpace(speciesLabelTextBox.Text))
				return;

			using (var zoo = new ZoophobiaContainer())
			{
				var species = new Species
				{
					EaterTypeId = eaterType.Id,
					EaterType = eaterType,
					EnvironmentId = environment.Id,
					Environment = environment,
					Label = speciesLabelTextBox.Text.Trim()
				};

				zoo.Species.Add(species);
				zoo.SaveChanges();
				speciesListBox.Items.Add(species);
			}
		}
	}
}
