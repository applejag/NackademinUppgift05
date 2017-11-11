using System.ComponentModel.DataAnnotations;

namespace NackademinUppgift05.Models
{
	public class AnimalParent
	{
		public int ChildId { get; set; }
		public int ParentId { get; set; }

		public virtual Animal Child { get; set; }
		public virtual Animal Parent { get; set; }
	}
}