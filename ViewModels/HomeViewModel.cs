using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.ViewModels
{
    public class HomeViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<Category> Categories { get; set; }
        public List<HowItWork> HowItWorks { get; set; }
        public List<SuccessStory> SuccessStories { get; set; }
        public List<Advice> Advices { get; set; }

        public List<Client> Clients { get; set; }

        public List<Country> Countries { get; set; }
    }
}