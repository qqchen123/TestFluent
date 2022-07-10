using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMS.Interface;
using TDMS.Model.Models;
using TDMS.Service;

namespace TDMS.AdminWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {

            IProjectInfoService infoService = new ProjectInfoService();
            IList<Product> ProductRes = infoService.getAllProduct();
            foreach (var item in ProductRes)
            {
                foreach (var i in item.Orders)
                {
                    var oid = i.OrderId;
                    var od = i.OrderDate;
                }
            }
            ViewBag.Product = ProductRes;
            return View();
        }


    }
}