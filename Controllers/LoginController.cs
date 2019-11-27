using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult EmployeeLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeLogin(Employee employee)
        {
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public ActionResult CandidateLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CandidateLogin(Candidate candidate)
        {
            return RedirectToAction("index", "home");
        }
    }
}