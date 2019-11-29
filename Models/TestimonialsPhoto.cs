using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class TestimonialsPhoto
    {
        public int Id { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Photo { get; set; }
        public int TestimonialId { get; set; }
        public Testimonial Testimonial { get; set; }
    }
}