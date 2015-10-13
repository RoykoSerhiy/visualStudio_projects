namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRegions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Street",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Region_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Region", t => t.Region_Id)
                .Index(t => t.Region_Id);
            
            CreateIndex("dbo.UserInfo", "Login", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Region", "City_Id", "dbo.City");
            DropForeignKey("dbo.Street", "Region_Id", "dbo.Region");
            DropIndex("dbo.Street", new[] { "Region_Id" });
            DropIndex("dbo.Region", new[] { "City_Id" });
            DropIndex("dbo.UserInfo", new[] { "Login" });
            DropTable("dbo.Street");
            DropTable("dbo.Region");
            DropTable("dbo.City");
        }
    }
}
