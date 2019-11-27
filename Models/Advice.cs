using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Advice
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}