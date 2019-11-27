using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class SuccessStory
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Position { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Photo { get; set; }

    }
}