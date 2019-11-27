namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobAndCompanyTablesModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "EducationId", "dbo.Educations");
            DropForeignKey("dbo.Jobs", "ExperienceId", "dbo.Experiences");
            DropForeignKey("dbo.KeyWords", "Job_Id", "dbo.Jobs");
            DropIndex("dbo.Jobs", new[] { "ExperienceId" });
            DropIndex("dbo.Jobs", new[] { "EducationId" });
            DropIndex("dbo.KeyWords", new[] { "Job_Id" });
            AddColumn("dbo.Advices", "Title", c => c.String());
            AddColumn("dbo.Candidates", "Password", c => c.String());
            AddColumn("dbo.Jobs", "TitleText", c => c.String());
            AddColumn("dbo.Jobs", "EducationRequirement", c => c.String());
            AddColumn("dbo.Categories", "Icon", c => c.String());
            AddColumn("dbo.Companies", "Service", c => c.String());
            AddColumn("dbo.SuccessStories", "Photo", c => c.String());
            DropColumn("dbo.Jobs", "Title");
            DropColumn("dbo.Jobs", "ExperienceId");
            DropColumn("dbo.Jobs", "EducationId");
            DropColumn("dbo.Jobs", "Photo");
            DropColumn("dbo.Companies", "Services");
            DropTable("dbo.KeyWords");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KeyWords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Job_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Companies", "Services", c => c.String());
            AddColumn("dbo.Jobs", "Photo", c => c.String());
            AddColumn("dbo.Jobs", "EducationId", c => c.Int(nullable: false));
            AddColumn("dbo.Jobs", "ExperienceId", c => c.Int(nullable: false));
            AddColumn("dbo.Jobs", "Title", c => c.String());
            DropColumn("dbo.SuccessStories", "Photo");
            DropColumn("dbo.Companies", "Service");
            DropColumn("dbo.Categories", "Icon");
            DropColumn("dbo.Jobs", "EducationRequirement");
            DropColumn("dbo.Jobs", "TitleText");
            DropColumn("dbo.Candidates", "Password");
            DropColumn("dbo.Advices", "Title");
            CreateIndex("dbo.KeyWords", "Job_Id");
            CreateIndex("dbo.Jobs", "EducationId");
            CreateIndex("dbo.Jobs", "ExperienceId");
            AddForeignKey("dbo.KeyWords", "Job_Id", "dbo.Jobs", "Id");
            AddForeignKey("dbo.Jobs", "ExperienceId", "dbo.Experiences", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Jobs", "EducationId", "dbo.Educations", "Id", cascadeDelete: true);
        }
    }
}
