﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "David hizo un ajuste a este titulo.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Aqui descanso";

            return View();
        }
    }
}