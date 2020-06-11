namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopEntity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Title", c => c.String(nullable: false, maxLength: 160));
            AlterColumn("dbo.Items", "ItemArtUrl", c => c.String(maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "ItemArtUrl", c => c.String());
            AlterColumn("dbo.Items", "Title", c => c.String());
        }
    }
}
