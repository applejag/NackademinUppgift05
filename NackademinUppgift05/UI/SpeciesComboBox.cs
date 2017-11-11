using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackademinUppgift05.UI
{
	public partial class SpeciesComboBox : UserControl
	{
		public Species SelectedSpecies => comboBox1.SelectedItem as Species;

		public SpeciesComboBox()
		{
			InitializeComponent();
		}

		private void LoadSpecies()
		{
			comboBox1.Items.Clear();
			using (var zoo = new ZoophobiaContainer())
				comboBox1.Items.AddRange(zoo.Species.ToArray());

			comboBox1.Enabled = comboBox1.Items.Count > 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new SpeciesPage().ShowDialog();
			LoadSpecies();
		}

		private void SpeciesComboBox_Load(object sender, EventArgs e)
		{
			LoadSpecies();
		}
	}
}
