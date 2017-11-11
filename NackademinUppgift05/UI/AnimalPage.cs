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
	public partial class AnimalPage : Form
	{
		//private Animal Animal { get; }

		public AnimalPage(/*Animal animal = null*/)
		{
			//this.Animal = animal ?? new Animal();

			InitializeComponent();
		}

		private void animalWeightTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (float.TryParse(animalWeightTextBox.Text, out float weight))
			{
				animalWeightTextBox.Text = weight.ToString();
				//animal.Weight = weight;
			}
			else
			{
				//animalWeightTextBox.Text = animal.Weight.ToString();
			}
		}
	}
}
