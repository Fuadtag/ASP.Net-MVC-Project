using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Experience
    {
        [Key, ForeignKey("Candidate")]
        public int Id { get; set; }
        public byte Year { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }




    }
}