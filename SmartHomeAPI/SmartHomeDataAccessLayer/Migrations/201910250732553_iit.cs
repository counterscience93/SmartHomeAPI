namespace SmartHomeDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        TimeUpDate = c.DateTime(),
                        UserUpdate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserUpdate)
                .Index(t => t.UserUpdate);
            
            CreateTable(
                "dbo.Device",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeviceName = c.String(maxLength: 100),
                        UserId = c.Int(nullable: false),
                        HouseId = c.Int(nullable: false),
                        DateActive = c.DateTime(),
                        DateCreated = c.DateTime(),
                        Status = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .ForeignKey("dbo.House", t => t.HouseId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.HouseId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.House",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseName = c.String(maxLength: 100),
                        UserId = c.Int(nullable: false),
                        DateActive = c.DateTime(),
                        DateCreated = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 10),
                        Email = c.String(maxLength: 100),
                        Token = c.String(maxLength: 50),
                        Address = c.String(maxLength: 255),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Category", "UserUpdate", "dbo.User");
            DropForeignKey("dbo.Device", "UserId", "dbo.User");
            DropForeignKey("dbo.Device", "HouseId", "dbo.House");
            DropForeignKey("dbo.House", "UserId", "dbo.User");
            DropForeignKey("dbo.Device", "CategoryId", "dbo.Category");
            DropIndex("dbo.House", new[] { "UserId" });
            DropIndex("dbo.Device", new[] { "CategoryId" });
            DropIndex("dbo.Device", new[] { "HouseId" });
            DropIndex("dbo.Device", new[] { "UserId" });
            DropIndex("dbo.Category", new[] { "UserUpdate" });
            DropTable("dbo.User");
            DropTable("dbo.House");
            DropTable("dbo.Device");
            DropTable("dbo.Category");
        }
    }
}
