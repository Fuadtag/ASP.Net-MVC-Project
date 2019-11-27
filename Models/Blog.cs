using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory{ get; set; }

        public List<BlogReview> BlogReviews { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public string FooterText { get; set; }

        public string Author { get; set; }
    }
}