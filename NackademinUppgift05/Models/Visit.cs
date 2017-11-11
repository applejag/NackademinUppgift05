using System;
using System.ComponentModel.DataAnnotations;

namespace NackademinUppgift05.Models
{
	public class Visit
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }

		[Required]
		public virtual Animal Animal { get; set; }
		[Required]
		public virtual Veterinarian Veterinarian { get; set; }
	}
}