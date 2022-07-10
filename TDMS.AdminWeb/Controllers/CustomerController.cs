using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMS.Interface;
using TDMS.Service;

namespace TDMS.AdminWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            IProjectInfoService infoService = new ProjectInfoService();
            var customerInfo = infoService.GetCustomer();
            ViewBag.customerInfo = customerInfo;
            return View();
        }
    }
}