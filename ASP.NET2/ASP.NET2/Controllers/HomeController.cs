﻿using ASP.NET2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
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
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult SaveUser(User u)
        {
            StreamWriter sw = new
             StreamWriter(Server.MapPath("~/App_Data/TextFile1.txt"), true);
            sw.WriteLine("User details added on: " +
             DateTime.Now.ToString());
            sw.WriteLine("User name: " + u.UserName);
            sw.WriteLine("Password: " + u.Password);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");
        }
        public ActionResult HtmlHelpers()
        {
            return View();
        }



    }
}