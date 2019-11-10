using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        // Ya con eso esta creado el metodo, lo del ViewBag es otro tema, entonces para crear la vista Click derecho sobre el metodo
        public ActionResult Galeria() {
            
            return View();
        }
         public ActionResult Blog() {
            
            return View();
        }   
            
    }
}