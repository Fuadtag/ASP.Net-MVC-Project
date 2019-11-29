using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class RegisterController : BaseController
    {
        // GET: Register
        [HttpGet]
        public ActionResult EmployeeRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeRegister(Employee employee)
        {
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public ActionResult CandidateRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CandidateRegister(Candidate candidate)
        {
            return RedirectToAction("index", "home");
        }
    }
}