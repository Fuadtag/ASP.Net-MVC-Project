using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class ServiceInfoPhoto
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUplaod { get; set; }
        public string Photo { get; set; }
    }
}