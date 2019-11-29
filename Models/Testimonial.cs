using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public string Text { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [NotMapped]
        public List<TestimonialsPhoto> Photos { get; set; }

    }
}