namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Text = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Text = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        Blog_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .Index(t => t.CandidateId)
                .Index(t => t.EmployeeId)
                .Index(t => t.Blog_Id);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        MiddleName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Marriage = c.Boolean(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        CountryId = c.Int(nullable: false),
                        AboutUs = c.String(),
                        Overview = c.String(),
                        ExperienceId = c.Int(nullable: false),
                        City = c.String(),
                        Phone = c.String(),
                        WebSite = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
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
                        Title = c.String(),
                        EmailAdress = c.String(),
                        WebSite = c.String(),
                        JobTypeId = c.Int(nullable: false),
                        JobType = c.Int(nullable: false),
                        City = c.String(),
                        CountryId = c.Int(nullable: false),
                        MinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Shift = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ExperienceId = c.Int(nullable: false),
                        EducationId = c.Int(nullable: false),
                        Description = c.String(),
                        Gender = c.Int(nullable: false),
                        Photo = c.String(),
                        IsAcceptedByAdmin = c.Boolean(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Educations", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.Experiences", t => t.ExperienceId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.CompanyId)
                .Index(t => t.CategoryId)
                .Index(t => t.ExperienceId)
                .Index(t => t.EducationId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
                        IsVerified = c.Boolean(nullable: false),
                        ExperienceYears = c.String(),
                        Photo = c.String(),
                        OverView = c.String(),
                        Services = c.String(),
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
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
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
                        EmailAdress = c.String(),
                        Password = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                        Star = c.Byte(nullable: false),
                        Rating = c.Byte(nullable: false),
                        IsAcceptedByAdmin = c.Boolean(nullable: false),
                        Photo = c.String(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Year = c.Byte(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Position = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AboutUs = c.String(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.KeyWords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Job_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.Job_Id)
                .Index(t => t.Job_Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                        FooterText = c.String(),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
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
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        FacebookLink = c.String(),
                        InstagramLink = c.String(),
                        TwitterLink = c.String(),
                        GoogleLink = c.String(),
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
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BlogReviews", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.BlogReviews", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Experiences", "Id", "dbo.Candidates");
            DropForeignKey("dbo.KeyWords", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Jobs", "ExperienceId", "dbo.Experiences");
            DropForeignKey("dbo.Jobs", "EducationId", "dbo.Educations");
            DropForeignKey("dbo.Jobs", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Employees", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.CompanyReviews", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CompanyReviews", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Jobs", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Candidates", "CountryId", "dbo.Countries");
            DropIndex("dbo.Tags", new[] { "BlogId" });
            DropIndex("dbo.Blogs", new[] { "CategoryId" });
            DropIndex("dbo.KeyWords", new[] { "Job_Id" });
            DropIndex("dbo.Experiences", new[] { "Id" });
            DropIndex("dbo.Employees", new[] { "Company_Id" });
            DropIndex("dbo.CompanyReviews", new[] { "EmployeeId" });
            DropIndex("dbo.CompanyReviews", new[] { "CompanyId" });
            DropIndex("dbo.Jobs", new[] { "EducationId" });
            DropIndex("dbo.Jobs", new[] { "ExperienceId" });
            DropIndex("dbo.Jobs", new[] { "CategoryId" });
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            DropIndex("dbo.Jobs", new[] { "CountryId" });
            DropIndex("dbo.Candidates", new[] { "CountryId" });
            DropIndex("dbo.BlogReviews", new[] { "Blog_Id" });
            DropIndex("dbo.BlogReviews", new[] { "EmployeeId" });
            DropIndex("dbo.BlogReviews", new[] { "CandidateId" });
            DropTable("dbo.Tags");
            DropTable("dbo.SuccessStories");
            DropTable("dbo.Settings");
            DropTable("dbo.HowItWorks");
            DropTable("dbo.Clients");
            DropTable("dbo.Blogs");
            DropTable("dbo.KeyWords");
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
            DropTable("dbo.Advices");
        }
    }
}
