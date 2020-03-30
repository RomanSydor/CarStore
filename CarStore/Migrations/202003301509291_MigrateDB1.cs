namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Purchases", "BrandId");
            DropColumn("dbo.Purchases", "CarModelId");
            DropColumn("dbo.Purchases", "ConfigId");
            DropColumn("dbo.Purchases", "CarColorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Purchases", "CarColorId", c => c.Int(nullable: false));
            AddColumn("dbo.Purchases", "ConfigId", c => c.Int(nullable: false));
            AddColumn("dbo.Purchases", "CarModelId", c => c.Int(nullable: false));
            AddColumn("dbo.Purchases", "BrandId", c => c.Int(nullable: false));
        }
    }
}
