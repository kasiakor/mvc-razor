﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string[] names = {"Apple", "Orange", "Pear" };
            return View(names);
        }

        public ActionResult List()
        {
            string[] fruit = { "Apple", "Orange", "Pomelo" };
            return View(fruit);

            //return View();
        }


        //optional attribute to avoid invoking by the user
        [ChildActionOnly]
        public ActionResult Time()
        {  
            return PartialView(DateTime.Now);
        }
    }
}