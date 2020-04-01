namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CarModels", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CarModels", "Price", c => c.Single(nullable: false));
        }
    }
}
