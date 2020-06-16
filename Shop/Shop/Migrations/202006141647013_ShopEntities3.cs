namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopEntities3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "State", c => c.String(nullable: false, maxLength: 40));
        }
    }
}
