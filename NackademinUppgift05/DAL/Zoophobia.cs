using System.Data.Entity;
using NackademinUppgift05.Models;

namespace NackademinUppgift05.DAL
{
	public class Zoophobia : DbContext
	{
		public Zoophobia()
			: base(Properties.Settings.Default.ZooDBConnection)
		{
		}

		public virtual DbSet<Animal> Animals { get; set; }
		public virtual DbSet<EaterType> EaterTypes { get; set; }
		public virtual DbSet<Environment> Environments { get; set; }
		public virtual DbSet<Species> Species { get; set; }
		public virtual DbSet<Veterinarian> Veterinarians { get; set; }
		public virtual DbSet<Visit> Visits { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AnimalParent>()
				.HasKey(e => new {e.ChildId, e.ParentId});

			modelBuilder.Entity<AnimalParent>() // child has many parents
				.HasRequired(e => e.Child)
				.WithMany(e => e.Parents)
				.HasForeignKey(e => e.ChildId);

			modelBuilder.Entity<AnimalParent>() // parent has many children
				.HasRequired(e => e.Parent)
				.WithMany(e => e.Children)
				.HasForeignKey(e => e.ParentId);

			base.OnModelCreating(modelBuilder);
		}
		
	}
}