namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttributesAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories");
            DropForeignKey("dbo.BlogReviews", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates");
            DropIndex("dbo.Blogs", new[] { "BlogCategoryId" });
            DropIndex("dbo.BlogReviews", new[] { "CandidateId" });
            DropIndex("dbo.BlogReviews", new[] { "BlogId" });
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.AboutUs", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.AboutUs", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Advices", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Advices", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Advices", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.BlogCategories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Blogs", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Blogs", "BlogCategoryId", c => c.Int());
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Blogs", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Blogs", "FooterText", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Blogs", "Author", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BlogReviews", "CandidateId", c => c.Int());
            AlterColumn("dbo.BlogReviews", "BlogId", c => c.Int());
            AlterColumn("dbo.BlogReviews", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.BlogReviews", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            CreateIndex("dbo.Blogs", "BlogCategoryId");
            CreateIndex("dbo.BlogReviews", "CandidateId");
            CreateIndex("dbo.BlogReviews", "BlogId");
            AddForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories", "Id");
            AddForeignKey("dbo.BlogReviews", "BlogId", "dbo.Blogs", "Id");
            AddForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.BlogReviews", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories");
            DropIndex("dbo.BlogReviews", new[] { "BlogId" });
            DropIndex("dbo.BlogReviews", new[] { "CandidateId" });
            DropIndex("dbo.Blogs", new[] { "BlogCategoryId" });
            AlterColumn("dbo.BlogReviews", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BlogReviews", "Text", c => c.String());
            AlterColumn("dbo.BlogReviews", "BlogId", c => c.Int(nullable: false));
            AlterColumn("dbo.BlogReviews", "CandidateId", c => c.Int(nullable: false));
            AlterColumn("dbo.Blogs", "Author", c => c.String());
            AlterColumn("dbo.Blogs", "FooterText", c => c.String());
            AlterColumn("dbo.Blogs", "Text", c => c.String());
            AlterColumn("dbo.Blogs", "Title", c => c.String());
            AlterColumn("dbo.Blogs", "BlogCategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Blogs", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BlogCategories", "Name", c => c.String());
            AlterColumn("dbo.Advices", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Advices", "Text", c => c.String());
            AlterColumn("dbo.Advices", "Title", c => c.String());
            AlterColumn("dbo.AboutUs", "Text", c => c.String());
            AlterColumn("dbo.AboutUs", "Title", c => c.String());
            DropTable("dbo.Admins");
            CreateIndex("dbo.BlogReviews", "BlogId");
            CreateIndex("dbo.BlogReviews", "CandidateId");
            CreateIndex("dbo.Blogs", "BlogCategoryId");
            AddForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BlogReviews", "BlogId", "dbo.Blogs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories", "Id", cascadeDelete: true);
        }
    }
}
