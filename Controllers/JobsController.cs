using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Jobs()
        {
            return View();
        }

        public ActionResult Jobdetails()
        {
            return View();
        }

        public  ActionResult Create()
        {
            return View();
        }
    }
}