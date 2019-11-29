﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Job> Jobs { get; set; }

       

        public string Icon { get; set; }
    }
}