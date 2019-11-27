using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class BlogReview
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}