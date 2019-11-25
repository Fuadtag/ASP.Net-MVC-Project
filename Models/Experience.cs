using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public byte Year { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string AboutUs { get; set; }


        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public List<string> Skills { get; set; }



    }
}