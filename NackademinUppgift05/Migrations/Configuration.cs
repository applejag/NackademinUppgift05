namespace NackademinUppgift05.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZoophobiaContainer>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZoophobiaContainer context)
        {
			context.Environments.AddOrUpdate(e => e.Id,
		        new NackademinUppgift05.Environment { Id = 1, Label = "Plains" },
		        new NackademinUppgift05.Environment { Id = 2, Label = "Forest" },
		        new NackademinUppgift05.Environment { Id = 3, Label = "Water" }
	        );

	        context.EaterTypes.AddOrUpdate(e => e.Id,
		        new EaterType { Id = 1, Label = "Carnivore" },
		        new EaterType { Id = 2, Label = "Herbivore" }
	        );

	        context.Veterinarians.AddOrUpdate(v => v.Id,
		        new Veterinarian { Id = 1, Name = "Aubrey Grigaliunas" },
		        new Veterinarian { Id = 2, Name = "Grace Knisley" },
		        new Veterinarian { Id = 3, Name = "Ayden Debreto" },
		        new Veterinarian { Id = 4, Name = "Tristen Woodhull" },
		        new Veterinarian { Id = 5, Name = "Brennan Kuhlman" },
		        new Veterinarian { Id = 6, Name = "Nova Seats" }
	        );

		}
	}
}
