using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class BlogCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}