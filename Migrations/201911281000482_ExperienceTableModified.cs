namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExperienceTableModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Experiences", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Experiences", "Year", c => c.Byte(nullable: false));
        }
    }
}
