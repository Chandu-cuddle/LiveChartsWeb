﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveChartsWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Banner
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}