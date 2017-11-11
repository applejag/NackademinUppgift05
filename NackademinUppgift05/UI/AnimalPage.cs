using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackademinUppgift05.UI
{
	public partial class AnimalPage : Form
	{
		private Animal Animal { get; }

		public AnimalPage(Animal animal = null)
		{
			this.Animal = animal ?? new Animal();

			InitializeComponent();
		}

		private void animalWeightTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (double.TryParse(animalWeightTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out double weight))
			{
				animalWeightTextBox.Text = weight.ToString(CultureInfo.CurrentCulture);
				Animal.Weight = weight;
			}
			else
			{
				animalWeightTextBox.Text = Animal.Weight.ToString(CultureInfo.CurrentCulture);
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void speciesComboBox1_Load(object sender, EventArgs e)
		{

		}
	}
}
