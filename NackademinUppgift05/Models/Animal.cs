using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NackademinUppgift05.Models
{
	public class Animal
	{
		public int Id { get; set; }
		[Required, MaxLength(255)]
		public string Name { get; set; }
		[MaxLength(255)]
		public string Origin { get; set; }
		public float Weight { get; set; }

		public virtual Species Species { get; set; }
		public virtual ICollection<Visit> Visits { get; set; }
		public virtual ICollection<Animal> Parents { get; set; }
		public virtual ICollection<Animal> Children { get; set; }
	}
}