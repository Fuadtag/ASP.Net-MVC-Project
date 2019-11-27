using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Adress { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public byte Star { get; set; }
        public List<string> Qualifications { get; set; }
        public byte Rating { get; set; }
        public List<CompanyReview> CompanyReviews { get; set; }
        public bool IsAcceptedByAdmin { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

    }
}