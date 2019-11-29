namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "BirthDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
