using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        public bool Gender { get; set; }

        public string Photo { get; set; }

        [NotMapped]
        public HttpPostedFile UploadPhoto { get; set; }

        public List<KeyWord> KeyWords { get; set; }
        public bool IsAcceptedByAdmin { get; set; }

        public string Note { get; set; }
    }
}