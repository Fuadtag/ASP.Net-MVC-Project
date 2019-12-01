using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="date")]
        public DateTime CreatedAt { get; set; }
        public int? BlogCategoryId { get; set; }
        public BlogCategory BlogCategory{ get; set; }

        public List<BlogReview> BlogReviews { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        [AllowHtml]
        public string Text { get; set; }
        [Required]
        [MaxLength(300)]

        public string FooterText { get; set; }
        [Required]
        [MaxLength(50)]

        public string Author { get; set; }
    }
}