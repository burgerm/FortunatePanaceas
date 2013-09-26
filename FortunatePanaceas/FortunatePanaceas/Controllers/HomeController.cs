using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortunatePanaceas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // TODO: This message should come from a database
            ViewBag.Message = "Welcome to Fortunate Panaceas!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
