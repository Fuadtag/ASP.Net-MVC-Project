namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyAddedToEmloyeeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "Company_Id" });
            RenameColumn(table: "dbo.Employees", name: "Company_Id", newName: "CompanyId");
            AlterColumn("dbo.Employees", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "CompanyId");
            AddForeignKey("dbo.Employees", "CompanyId", "dbo.Companies", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            AlterColumn("dbo.Employees", "CompanyId", c => c.Int());
            RenameColumn(table: "dbo.Employees", name: "CompanyId", newName: "Company_Id");
            CreateIndex("dbo.Employees", "Company_Id");
            AddForeignKey("dbo.Employees", "Company_Id", "dbo.Companies", "Id");
        }
    }
}
