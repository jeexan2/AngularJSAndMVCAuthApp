﻿using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_App_v1.Controllers
{
    public class HomeController : Controller
    {
        // BusinessClass _businessClass = new BusinessClass();
        IBusiness businessClass;
        public HomeController(IBusiness _businessClass){
            businessClass = _businessClass;
        }
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
    }
}