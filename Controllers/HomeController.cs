using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mlaMVC2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome, to MurphyLomon Online!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
