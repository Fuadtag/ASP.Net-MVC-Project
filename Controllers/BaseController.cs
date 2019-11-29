using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Data;

namespace AspNetFinalProject.Controllers
{


    public class BaseController : Controller
    {
        protected readonly JoobsyContext context;

        public BaseController()
        {
            context = new JoobsyContext();
        }
    }
}