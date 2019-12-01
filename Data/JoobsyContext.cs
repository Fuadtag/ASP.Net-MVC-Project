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
        public JoobsyContext():base("JobContext")
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
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceInfo> ServiceInfos { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<TestimonialsPhoto> TestimonialsPhotos { get; set; }

        public DbSet<ServiceInfoPhoto> ServiceInfoPhotos { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}