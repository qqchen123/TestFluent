﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMS.Service;
using TDMS.Interface;

namespace TDMS.AdminWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IProjectInfoService infoService = new ProjectInfoService();
            //infoService.GetAllCate();
            string info = infoService.DoMyTest();
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