using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Models
{
    public class BlogReview
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        
        public int? BlogId { get; set; }
        public Blog Blog { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        [AllowHtml]
        public string Text { get; set; }

        [Required]
        [Column(TypeName ="date")]
        public DateTime CreatedAt { get; set; }
    }
}