namespace WebApplication.datalayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "IsOnSale", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "IsOnSale");
        }
    }
}
