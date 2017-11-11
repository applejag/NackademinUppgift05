using System.Collections;
using System.Collections.Generic;

namespace NackademinUppgift05.Models
{
	public class Animal
	{
		public int AnimalId { get; set; }
		public string AnimalName { get; set; }
		public string AnimalOrigin { get; set; }
		public float AnimalWeight { get; set; }
		
		public Species Species { get; set; }
		public ICollection<Visit> Visits { get; set; }
		public ICollection<Animal> Parents { get; set; }
		public ICollection<Animal> Children { get; set; }
	}
}