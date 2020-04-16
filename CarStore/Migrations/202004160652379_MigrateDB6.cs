namespace CarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Purchases", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Purchases", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Purchases", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Purchases", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Purchases", "Email", c => c.String());
            AlterColumn("dbo.Purchases", "Phone", c => c.String());
            AlterColumn("dbo.Purchases", "LastName", c => c.String());
            AlterColumn("dbo.Purchases", "FirstName", c => c.String());
        }
    }
}
