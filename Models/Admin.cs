using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [MaxLength(50)]
        [Required]
        public string FullName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }
}