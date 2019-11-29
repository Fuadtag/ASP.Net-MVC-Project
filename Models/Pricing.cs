using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Bandwidth { get; set; }
        public string Onlinespace { get; set; }
        public bool Support { get; set; }
        public int Domain { get; set; }
        public bool HiddenFees { get; set; }
    }
}