namespace NackademinUppgift05.Models
{
	public class Species
	{
		public int SpeciesId { get; set; }
		public string SpeciesLabel { get; set; }
		
		public EaterType EaterType { get; set; }
		public Environment Environment { get; set; }
	}
}