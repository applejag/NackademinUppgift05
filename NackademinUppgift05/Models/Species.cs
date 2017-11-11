using System.ComponentModel.DataAnnotations;

namespace NackademinUppgift05.Models
{
	public class Species
	{
		public int Id { get; set; }
		[Required, MaxLength(255)]
		public string Label { get; set; }

		[Required]
		public virtual EaterType EaterType { get; set; }
		[Required]
		public virtual Environment Environment { get; set; }
	}
}