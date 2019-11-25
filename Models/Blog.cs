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
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<BlogReview> BlogReviews { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public string FooterText { get; set; }

        public string Author { get; set; }
    }
}