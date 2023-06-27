﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abogados.Controllers
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

        public ActionResult Servicios()
        {
            ViewBag.Message = "Pagina de servicios";

            return View();
        }

        public ActionResult Nosotros() 
        {
            ViewBag.Message = "Nosotros";

            return View();
        }
    }
}