using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Marriage { get; set; }
        public bool Gender { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public string AboutUs { get; set; }
        public string Overview { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string Adress { get; set; }

        public string Email { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

    }
}