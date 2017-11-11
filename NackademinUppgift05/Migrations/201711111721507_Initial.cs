namespace NackademinUppgift05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Origin = c.String(maxLength: 255),
                        Weight = c.Single(nullable: false),
                        Species_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Species", t => t.Species_Id)
                .Index(t => t.Species_Id);
            
            CreateTable(
                "dbo.AnimalParents",
                c => new
                    {
                        ChildId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ChildId, t.ParentId })
                .ForeignKey("dbo.Animals", t => t.ChildId, cascadeDelete: true)
                .ForeignKey("dbo.Animals", t => t.ParentId, cascadeDelete: true)
                .Index(t => t.ChildId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(nullable: false, maxLength: 255),
                        EaterType_Id = c.Int(nullable: false),
                        Environment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EaterTypes", t => t.EaterType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Environments", t => t.Environment_Id, cascadeDelete: true)
                .Index(t => t.EaterType_Id)
                .Index(t => t.Environment_Id);
            
            CreateTable(
                "dbo.EaterTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Environments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Animal_Id = c.Int(nullable: false),
                        Veterinarian_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.Animal_Id, cascadeDelete: true)
                .ForeignKey("dbo.Veterinarians", t => t.Veterinarian_Id, cascadeDelete: true)
                .Index(t => t.Animal_Id)
                .Index(t => t.Veterinarian_Id);
            
            CreateTable(
                "dbo.Veterinarians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "Veterinarian_Id", "dbo.Veterinarians");
            DropForeignKey("dbo.Visits", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.Animals", "Species_Id", "dbo.Species");
            DropForeignKey("dbo.Species", "Environment_Id", "dbo.Environments");
            DropForeignKey("dbo.Species", "EaterType_Id", "dbo.EaterTypes");
            DropForeignKey("dbo.AnimalParents", "ParentId", "dbo.Animals");
            DropForeignKey("dbo.AnimalParents", "ChildId", "dbo.Animals");
            DropIndex("dbo.Visits", new[] { "Veterinarian_Id" });
            DropIndex("dbo.Visits", new[] { "Animal_Id" });
            DropIndex("dbo.Species", new[] { "Environment_Id" });
            DropIndex("dbo.Species", new[] { "EaterType_Id" });
            DropIndex("dbo.AnimalParents", new[] { "ParentId" });
            DropIndex("dbo.AnimalParents", new[] { "ChildId" });
            DropIndex("dbo.Animals", new[] { "Species_Id" });
            DropTable("dbo.Veterinarians");
            DropTable("dbo.Visits");
            DropTable("dbo.Environments");
            DropTable("dbo.EaterTypes");
            DropTable("dbo.Species");
            DropTable("dbo.AnimalParents");
            DropTable("dbo.Animals");
        }
    }
}
