namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogCategoryTableCreated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blogs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Blogs", new[] { "CategoryId" });
            CreateTable(
                "dbo.BlogCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Blogs", "BlogCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Settings", "Address", c => c.String());
            AddColumn("dbo.Settings", "Logo", c => c.String());
            CreateIndex("dbo.Blogs", "BlogCategoryId");
            AddForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.Blogs", "CategoryId");
            DropColumn("dbo.Settings", "Adress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "Adress", c => c.String());
            AddColumn("dbo.Blogs", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories");
            DropIndex("dbo.Blogs", new[] { "BlogCategoryId" });
            DropColumn("dbo.Settings", "Logo");
            DropColumn("dbo.Settings", "Address");
            DropColumn("dbo.Blogs", "BlogCategoryId");
            DropTable("dbo.BlogCategories");
            CreateIndex("dbo.Blogs", "CategoryId");
            AddForeignKey("dbo.Blogs", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
