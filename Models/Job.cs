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
        public string TitleText { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }
        public JobTypes JobType { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public Shifts Shift { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<string> Qualifications { get; set; }
        public List<string>  Responsibilities { get; set; }
        public string Notes { get; set; }

        public string Experience { get; set; }

        public string Description { get; set; }
        public Genders Gender { get; set; }
        
        public bool IsAcceptedByAdmin { get; set; }

        
    }


    public enum Genders
    {
        Male ,
        Female 
    }

    public enum Shifts
    {
        Morning ,
        Evening 
    }

    public enum JobTypes
    {
        FullTime ,
        PartTime 
    }
}