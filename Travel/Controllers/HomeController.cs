﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel.Controllers
{
    public class HomeController : Controller
    {
        public AcrtionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
