namespace Store.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "category_ID" });
            CreateIndex("dbo.Products", "Category_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "Category_ID" });
            CreateIndex("dbo.Products", "category_ID");
        }
    }
}
