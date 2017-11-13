using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace NackademinUppgift05.UI
{
	public partial class VetenarianVisits : UserControl
	{
		public ZoophobiaContainer zoo => (Parent as AnimalPage)?.zoo;
		public Animal Animal => (Parent as AnimalPage)?.Animal;

		public VetenarianVisits()
		{
			InitializeComponent();
		}

		private void VetenarianVisits_Load(object sender, EventArgs e)
		{
			LoadVisits();
		}

		private void LoadVisits()
		{
			visitsListBox.Items.Clear();
			Visit[] visits = Animal?.Visits
				.OrderBy(v => v.Date)
				.ToArray();

			if (visits == null || visits.Length == 0)
			{
				visitsListBox.Items.Add("<No visits yet>");
				visitsListBox.Enabled = false;
			}
			else
			{
				visitsListBox.Items.AddRange(visits);
				visitsListBox.Enabled = true;
			}
		}

		private void visitsBookButton_Click(object sender, EventArgs e)
		{
			new BookVisitPage(zoo, Animal).ShowDialog();
			LoadVisits();
		}

		private void visitsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			visitCancelButton.Enabled = visitsListBox.SelectedItem is Visit;
		}
	}
}
