using System.ComponentModel.DataAnnotations;

namespace NackademinUppgift05.Models
{
	public class Environment
	{
		public int Id { get; set; }
		[Required, MaxLength(255)]
		public string Label { get; set; }
	}
}