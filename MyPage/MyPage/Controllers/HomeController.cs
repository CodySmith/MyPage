﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AboutMe()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Reviews()
        {
            ViewBag.Message = "Reviews";

            return View();
        }

        public ActionResult Galaga()
        {
            ViewBag.Message = "Galaga Game";

            return View();
        }
    }
}
