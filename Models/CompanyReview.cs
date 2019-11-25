using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class CompanyReview
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }
    }
}