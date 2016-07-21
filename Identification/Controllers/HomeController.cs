using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Identification.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboards()
        {
            return View();
        }
        
         public ActionResult Rapport()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Une équipe à votre service";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pour toute question, n'hésitez pas à nous contacter.";

            return View();
        }
    }
}