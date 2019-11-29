using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.ViewModels;

namespace AspNetFinalProject.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel()
            {
                Categories = context.Categories.Include("Jobs").Take(3).ToList(),
                Jobs = context.Jobs.Include("Company").Take(4).ToList(),
                HowItWorks = context.HowItWorks.ToList(),
                SuccessStories = context.SuccessStories.ToList(),
                Advices = context.Advices.ToList(),
                Clients = context.Clients.ToList(),
                Countries = context.Countries.ToList()
            };
            return View(model);
        }

        
    }
}