namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "FirstName", c => c.String());
            AddColumn("dbo.Purchases", "LastName", c => c.String());
            AddColumn("dbo.Purchases", "Email", c => c.String());
            DropColumn("dbo.Purchases", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Purchases", "Customer", c => c.String());
            DropColumn("dbo.Purchases", "Email");
            DropColumn("dbo.Purchases", "LastName");
            DropColumn("dbo.Purchases", "FirstName");
        }
    }
}
