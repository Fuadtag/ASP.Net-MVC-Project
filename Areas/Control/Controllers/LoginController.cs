using AspNetFinalProject.Data;
using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AspNetFinalProject.Areas.Control.Controllers
{
    public class LoginController : Controller
    {

        private readonly JoobsyContext db;

        public LoginController()
        {
            db = new JoobsyContext();
        }
        // GET: Control/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Admin dbadmin = db.Admins.FirstOrDefault(a => a.Email == admin.Email);
            if (dbadmin == null)
            {
                ModelState.AddModelError("Email" ,"Invalid Email or Password");

            }
            if (Crypto.VerifyHashedPassword(dbadmin.Password, admin.Password))
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }
    }
}