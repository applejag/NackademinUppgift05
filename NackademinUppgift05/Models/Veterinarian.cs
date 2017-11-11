using System.Collections.Generic;

namespace NackademinUppgift05.Models
{
	public class Veterinarian
	{
		public int VeterinarianId { get; set; }
		public string VeterinarianName { get; set; }

		public ICollection<Visit> Visits { get; set; }
	}
}