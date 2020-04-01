namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarColors", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.CarModels", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Configs", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Purchases", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "Price");
            DropColumn("dbo.Configs", "Price");
            DropColumn("dbo.CarModels", "Price");
            DropColumn("dbo.CarColors", "Price");
        }
    }
}
