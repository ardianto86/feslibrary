using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FesLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Catalogue()
        {
            ViewBag.Message = "Catalogue";
            return View();
        }

        public ActionResult Borrow()
        {
            ViewBag.Message = "Borrow";

            return View();
        }

        public ActionResult Extend()
        {
            ViewBag.Message = "Extend";

            return View();
        }

        public ActionResult Return()
        {
            ViewBag.Message = "Return";

            return View();
        }
    }
}