namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Adress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Adress");
        }
    }
}
