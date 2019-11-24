using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class CandidatesController : Controller
    {
        // GET: Candidates
        public ActionResult Listing()
        {
            return View();
        }

        public ActionResult CandidateProfile()
        {
            return View();
        }

        public ActionResult CreateResume()
        {
            return View();
        }
    }
}