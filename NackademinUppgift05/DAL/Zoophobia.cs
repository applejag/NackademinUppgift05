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
			modelBuilder.Entity<Animal>()
				.HasMany(a => a.Children)
				.WithMany(a => a.Parents)
				.Map(a =>
				{
					a.MapLeftKey("ChildId");
					a.MapRightKey("ParentId");
					a.ToTable("AnimalParents");
				});

			base.OnModelCreating(modelBuilder);
		}
		
	}
}