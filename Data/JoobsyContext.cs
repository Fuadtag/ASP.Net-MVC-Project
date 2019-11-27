using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Data
{
    public class JoobsyContext:DbContext
    {
        public JoobsyContext():base("JoobsyContext")
        {

        }

        public DbSet<Advice> Advices { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogReview> BlogReviews { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyReview> CompanyReviews { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HowItWork> HowItWorks { get; set; }
        public DbSet<Job> Jobs { get; set; }
        
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SuccessStory> SuccessStories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }
    }
}