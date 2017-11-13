using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackademinUppgift05.UI
{
	public partial class BookVisitPage : Form
	{
		private readonly ZoophobiaContainer zoo;
		private readonly Animal animal;

		public BookVisitPage(ZoophobiaContainer zoo, Animal animal)
		{
			this.zoo = zoo;
			this.animal = animal;

			InitializeComponent();
		}

		private void BookVisitPage_Load(object sender, EventArgs e)
		{
			veterinariansComboBox.Items.AddRange(zoo.Veterinarians.ToArray());
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (!(veterinariansComboBox.SelectedItem is Veterinarian veterinarian))
				return;

			animal.Visits.Add(new Visit
			{
				Date = dateTimePicker.Value,
				Veterinarian = veterinarian,
			});

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
