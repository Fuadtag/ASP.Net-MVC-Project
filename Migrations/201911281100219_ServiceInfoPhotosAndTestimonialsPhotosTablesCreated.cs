namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceInfoPhotosAndTestimonialsPhotosTablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceInfoPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        Photo = c.String(),
                        ServiceInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceInfoes", t => t.ServiceInfo_Id)
                .Index(t => t.ServiceId)
                .Index(t => t.ServiceInfo_Id);
            
            CreateTable(
                "dbo.TestimonialsPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        TestimonialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Testimonials", t => t.TestimonialId, cascadeDelete: true)
                .Index(t => t.TestimonialId);
            
            DropColumn("dbo.Testimonials", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Testimonials", "Title", c => c.String());
            DropForeignKey("dbo.TestimonialsPhotoes", "TestimonialId", "dbo.Testimonials");
            DropForeignKey("dbo.ServiceInfoPhotoes", "ServiceInfo_Id", "dbo.ServiceInfoes");
            DropForeignKey("dbo.ServiceInfoPhotoes", "ServiceId", "dbo.Services");
            DropIndex("dbo.TestimonialsPhotoes", new[] { "TestimonialId" });
            DropIndex("dbo.ServiceInfoPhotoes", new[] { "ServiceInfo_Id" });
            DropIndex("dbo.ServiceInfoPhotoes", new[] { "ServiceId" });
            DropTable("dbo.TestimonialsPhotoes");
            DropTable("dbo.ServiceInfoPhotoes");
        }
    }
}
