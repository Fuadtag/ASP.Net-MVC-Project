namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tags", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tags", "Text");
        }
    }
}
