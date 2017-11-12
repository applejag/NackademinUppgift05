using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackademinUppgift05.UI
{
	public partial class SpeciesComboBox : UserControl
	{
		public Species SelectedSpecies
		{
			get => comboBox1.SelectedItem as Species;
			set => comboBox1.SelectedIndex = value == null ? -1 : comboBox1.Items.IndexOf(value);
		}

		public SpeciesComboBox()
		{
			InitializeComponent();
			LoadSpecies();
		}

		private void LoadSpecies()
		{
			comboBox1.Items.Clear();
			try
			{
				using (var zoo = new ZoophobiaContainer())
					comboBox1.Items.AddRange(zoo.Species
						.Include(s => s.EaterType)
						.Include(s => s.Environment)
						.ToArray());
			}
			catch
			{}

			comboBox1.Enabled = comboBox1.Items.Count > 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new SpeciesPage().ShowDialog();
			LoadSpecies();
		}
	}
}
