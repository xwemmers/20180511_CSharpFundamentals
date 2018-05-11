using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult AlleStudenten()
        {
            var lijst = new[] { "Frank", "Marijn", "Ad", "Joell", "Hakan", "Xander" };

            ViewBag.Boodschap = "Het is bijna weekend!";

            return View(lijst);
        }
    }
}