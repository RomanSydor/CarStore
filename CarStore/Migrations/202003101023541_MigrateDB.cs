namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RGBCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Configs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CarModelId = c.Int(nullable: false),
                        Transmission = c.String(),
                        EngineType = c.String(),
                        EngineVolume = c.Single(nullable: false),
                        WheelSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer = c.String(),
                        Phone = c.String(),
                        Date = c.DateTime(nullable: false),
                        BrandId = c.Int(nullable: false),
                        CarModelId = c.Int(nullable: false),
                        ConfigId = c.Int(nullable: false),
                        CarColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Purchases");
            DropTable("dbo.Configs");
            DropTable("dbo.CarModels");
            DropTable("dbo.CarColors");
            DropTable("dbo.Brands");
        }
    }
}
