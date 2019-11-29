using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class PagesController : BaseController
    {
        // GET: Pages
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Faqs()
        {
            return View();
        }
        public ActionResult PricingPlans()
        {
            return View();
        }
        
    }
}