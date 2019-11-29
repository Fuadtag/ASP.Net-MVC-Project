namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        BlogCategoryId = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                        FooterText = c.String(),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogCategories", t => t.BlogCategoryId, cascadeDelete: false)
                .Index(t => t.BlogCategoryId);
            
            CreateTable(
                "dbo.BlogReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        BlogId = c.Int(nullable: false),
                        Text = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: false)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .Index(t => t.CandidateId)
                .Index(t => t.EmployeeId)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        MiddleName = c.String(),
                        BirthDate = c.DateTime(nullable: false, storeType: "date"),
                        Marriage = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Password = c.String(),
                        CountryId = c.Int(nullable: false),
                        AboutUs = c.String(),
                        Overview = c.String(),
                        City = c.String(),
                        Phone = c.String(),
                        WebSite = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TitleText = c.String(),
                        EmailAdress = c.String(),
                        WebSite = c.String(),
                        JobType = c.Int(nullable: false),
                        City = c.String(),
                        CountryId = c.Int(nullable: false),
                        MinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Shift = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Description = c.String(),
                        Gender = c.Int(nullable: false),
                        IsAcceptedByAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: false)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .Index(t => t.CountryId)
                .Index(t => t.CompanyId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adress = c.String(),
                        CompanyType = c.String(),
                        WebSite = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        IsVerified = c.Boolean(nullable: false),
                        ExperienceYears = c.String(),
                        Photo = c.String(),
                        OverView = c.String(),
                        Service = c.String(),
                        FacebookLink = c.String(),
                        InstagramLink = c.String(),
                        TwitterLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .Index(t => t.CompanyId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        UserName = c.String(),
                        Adress = c.String(),
                        EmailAdress = c.String(),
                        Password = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        Star = c.Byte(nullable: false),
                        Rating = c.Byte(nullable: false),
                        IsAcceptedByAdmin = c.Boolean(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Icon = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        University = c.String(),
                        Degree = c.String(),
                        Description = c.String(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: false)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Byte(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Position = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CandidateId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: false)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CandidateId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: false)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faqs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HowItWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pricings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bandwidth = c.String(),
                        Onlinespace = c.String(),
                        Support = c.Boolean(nullable: false),
                        Domain = c.Int(nullable: false),
                        HiddenFees = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        FacebookLink = c.String(),
                        InstagramLink = c.String(),
                        TwitterLink = c.String(),
                        GoogleLink = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SuccessStories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Author = c.String(),
                        Position = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: false)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Testimonials", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Tags", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Skills", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Experiences", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Experiences", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Educations", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Jobs", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyReviews", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyReviews", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Jobs", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Candidates", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.BlogReviews", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "BlogCategoryId", "dbo.BlogCategories");
            DropIndex("dbo.Testimonials", new[] { "CompanyId" });
            DropIndex("dbo.Tags", new[] { "BlogId" });
            DropIndex("dbo.Skills", new[] { "CandidateId" });
            DropIndex("dbo.Experiences", new[] { "CompanyId" });
            DropIndex("dbo.Experiences", new[] { "CandidateId" });
            DropIndex("dbo.Educations", new[] { "CandidateId" });
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropIndex("dbo.CompanyReviews", new[] { "EmployeeId" });
            DropIndex("dbo.CompanyReviews", new[] { "CompanyId" });
            DropIndex("dbo.Jobs", new[] { "CategoryId" });
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            DropIndex("dbo.Jobs", new[] { "CountryId" });
            DropIndex("dbo.Candidates", new[] { "CountryId" });
            DropIndex("dbo.BlogReviews", new[] { "BlogId" });
            DropIndex("dbo.BlogReviews", new[] { "EmployeeId" });
            DropIndex("dbo.BlogReviews", new[] { "CandidateId" });
            DropIndex("dbo.Blogs", new[] { "BlogCategoryId" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.Tags");
            DropTable("dbo.SuccessStories");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceInfoes");
            DropTable("dbo.Pricings");
            DropTable("dbo.HowItWorks");
            DropTable("dbo.Faqs");
            DropTable("dbo.Clients");
            DropTable("dbo.Skills");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Employees");
            DropTable("dbo.CompanyReviews");
            DropTable("dbo.Companies");
            DropTable("dbo.Categories");
            DropTable("dbo.Jobs");
            DropTable("dbo.Countries");
            DropTable("dbo.Candidates");
            DropTable("dbo.BlogReviews");
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogCategories");
            DropTable("dbo.Advices");
        }
    }
}
