using System;

namespace NackademinUppgift05.Models
{
	public class Visit
	{
		public int VisitId { get; set; }
		public DateTime VisitDate { get; set; }

		public Animal Animal { get; set; }
		public Veterinarian Veterinarian { get; set; }
	}
}