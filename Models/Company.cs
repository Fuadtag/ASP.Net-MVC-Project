using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Email { get; set; }
        public bool IsVerified { get; set; }

        public List<Employee> Employees { get; set; }
        public string ExperienceYears { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Photo { get; set; }

        public List<CompanyReview> CompanyReviews { get; set; }
        public string OverView { get; set; }
        public string Service { get; set; }
        public List<string> Details { get; set; }

        public List<string> OpeningHours { get; set; }

        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        


    }
}