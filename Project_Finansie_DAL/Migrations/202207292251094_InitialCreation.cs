namespace Project_Finansie_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Betalingen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Datum = c.DateTime(nullable: false),
                        Hoeveelheid = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(nullable: false, maxLength: 50),
                        Kapitaal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ontvangste",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Datum = c.DateTime(nullable: false),
                        Hoeveelheid = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Betalingen", "UserId", "dbo.User");
            DropForeignKey("dbo.Ontvangste", "UserId", "dbo.User");
            DropIndex("dbo.Ontvangste", new[] { "UserId" });
            DropIndex("dbo.Betalingen", new[] { "UserId" });
            DropTable("dbo.Ontvangste");
            DropTable("dbo.User");
            DropTable("dbo.Betalingen");
        }
    }
}
