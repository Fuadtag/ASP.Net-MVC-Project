using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string University { get; set; }

        public string Degree { get; set; }
        public string Description { get; set; }



    }
}