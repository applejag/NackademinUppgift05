using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NackademinUppgift05.Models
{
	public class Veterinarian
	{
		public int Id { get; set; }
		[Required, MaxLength(255)]
		public string Name { get; set; }

		public virtual ICollection<Visit> Visits { get; set; }
	}
}