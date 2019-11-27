using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string GoogleLink { get; set; }

        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoUpload { get; set; }


    }
}