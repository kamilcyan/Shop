namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopEntities2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "ProducerId", "dbo.Producers");
            DropIndex("dbo.Items", new[] { "ProducerId" });
            DropColumn("dbo.Items", "ProducerId");
            DropTable("dbo.Producers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        ProducerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProducerId);
            
            AddColumn("dbo.Items", "ProducerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "ProducerId");
            AddForeignKey("dbo.Items", "ProducerId", "dbo.Producers", "ProducerId", cascadeDelete: true);
        }
    }
}
