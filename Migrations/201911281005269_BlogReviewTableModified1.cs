namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogReviewTableModified1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.BlogReviews", new[] { "EmployeeId" });
            DropColumn("dbo.BlogReviews", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogReviews", "EmployeeId", c => c.Int());
            CreateIndex("dbo.BlogReviews", "EmployeeId");
            AddForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees", "Id");
        }
    }
}
