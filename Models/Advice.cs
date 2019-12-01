using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Models
{
    public class Advice
    {
        public int Id { get; set; }
        [MaxLength]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        [AllowHtml]
        public string Text { get; set; }
        [Required]
        [Column(TypeName ="date")]
        public DateTime CreatedAt { get; set; }
    }
}