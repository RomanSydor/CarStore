namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "BrandId", c => c.Int(nullable: false));
            AddColumn("dbo.Purchases", "CarModelId", c => c.Int(nullable: false));
            AddColumn("dbo.Purchases", "ConfigId", c => c.Int(nullable: false));
            AddColumn("dbo.Purchases", "CarColorId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "CarColorId");
            DropColumn("dbo.Purchases", "ConfigId");
            DropColumn("dbo.Purchases", "CarModelId");
            DropColumn("dbo.Purchases", "BrandId");
        }
    }
}
