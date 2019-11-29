namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Notes", c => c.String());
            AddColumn("dbo.Jobs", "Experience", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "Experience");
            DropColumn("dbo.Jobs", "Notes");
        }
    }
}
