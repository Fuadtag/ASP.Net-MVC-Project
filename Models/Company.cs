using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }
        public string CompanyType { get; set; }
        public string WebSite { get; set; }
        public string Phone { get; set; }

        public bool IsVerified { get; set; }

        public List<Employee> Employees { get; set; }
        public string ExperienceYears { get; set; }

        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Photo { get; set; }

        public List<CompanyReview> CompanyReviews { get; set; }
        public string OverView { get; set; }
        public string Services { get; set; }

    }
}