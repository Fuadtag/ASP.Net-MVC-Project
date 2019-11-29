namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogReviewTableModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.BlogReviews", new[] { "EmployeeId" });
            AlterColumn("dbo.BlogReviews", "EmployeeId", c => c.Int());
            CreateIndex("dbo.BlogReviews", "EmployeeId");
            AddForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.BlogReviews", new[] { "EmployeeId" });
            AlterColumn("dbo.BlogReviews", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.BlogReviews", "EmployeeId");
            AddForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
