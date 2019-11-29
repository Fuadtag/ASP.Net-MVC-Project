using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFinalProject.Controllers
{
    public class EmployeesController : BaseController
    {
        // GET: Employees
        public ActionResult EmployeesList()
        {
            return View();
        }

        public ActionResult CompanyDetails()
        {
            return View();
        }
    }
}