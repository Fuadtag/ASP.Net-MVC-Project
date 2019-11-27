namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Email", c => c.String());
            DropColumn("dbo.Jobs", "EducationRequirement");
            DropColumn("dbo.Jobs", "Note");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "Note", c => c.String());
            AddColumn("dbo.Jobs", "EducationRequirement", c => c.String());
            DropColumn("dbo.Companies", "Email");
        }
    }
}
