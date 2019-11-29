using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class ServiceInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public List<ServiceInfoPhoto> Photos { get; set; }

    }
}