namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class historyFixed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                        Surname = c.String(maxLength: 60),
                        MiddleName = c.String(maxLength: 60),
                        Phone = c.String(maxLength: 60),
                        Login = c.String(nullable: false, maxLength: 18),
                        Password = c.String(nullable: false, maxLength: 18),
                        Nationality = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarBrand = c.String(nullable: false, maxLength: 60),
                        CarModel = c.String(nullable: false, maxLength: 60),
                        VehicleType = c.Int(nullable: false),
                        CarNumber = c.String(nullable: false, maxLength: 8),
                        CarClass = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.History",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        DepatureAddress = c.String(nullable: false, maxLength: 60),
                        DestinationAddress = c.String(nullable: false, maxLength: 60),
                        Driver_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DriverProfile", t => t.Driver_Id)
                .ForeignKey("dbo.UserProfile", t => t.User_Id)
                .Index(t => t.Driver_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserInfoRoles",
                c => new
                    {
                        UserInfo_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserInfo_Id, t.Role_Id })
                .ForeignKey("dbo.UserInfo", t => t.UserInfo_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.UserInfo_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.DriverProfile",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Car_Id = c.Int(),
                        LicenseNum = c.String(nullable: false, maxLength: 6),
                        LicenseValidDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo", t => t.Id)
                .ForeignKey("dbo.Car", t => t.Car_Id)
                .Index(t => t.Id)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfile", "Id", "dbo.UserInfo");
            DropForeignKey("dbo.DriverProfile", "Car_Id", "dbo.Car");
            DropForeignKey("dbo.DriverProfile", "Id", "dbo.UserInfo");
            DropForeignKey("dbo.Admin", "Id", "dbo.UserInfo");
            DropForeignKey("dbo.History", "User_Id", "dbo.UserProfile");
            DropForeignKey("dbo.History", "Driver_Id", "dbo.DriverProfile");
            DropForeignKey("dbo.UserInfoRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserInfoRoles", "UserInfo_Id", "dbo.UserInfo");
            DropIndex("dbo.UserProfile", new[] { "Id" });
            DropIndex("dbo.DriverProfile", new[] { "Car_Id" });
            DropIndex("dbo.DriverProfile", new[] { "Id" });
            DropIndex("dbo.Admin", new[] { "Id" });
            DropIndex("dbo.UserInfoRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserInfoRoles", new[] { "UserInfo_Id" });
            DropIndex("dbo.History", new[] { "User_Id" });
            DropIndex("dbo.History", new[] { "Driver_Id" });
            DropTable("dbo.UserProfile");
            DropTable("dbo.DriverProfile");
            DropTable("dbo.Admin");
            DropTable("dbo.UserInfoRoles");
            DropTable("dbo.History");
            DropTable("dbo.Car");
            DropTable("dbo.Roles");
            DropTable("dbo.UserInfo");
        }
    }
}
