using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFluent.Manager;
using TestFluent.Models;

namespace TestFluent.Controllers
{
    public class CateController : Controller
    {
        CateManager cateManager;
        public CateController()
        {
            this.cateManager = new CateManager();
        }
        // GET: Cate
        public ActionResult Index()
        {
            IList<Cate> cateList = this.cateManager.GetAllCate();
            ViewBag.cateList = cateList;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cate cate)
        {
            try
            {
                // TODO: Add insert logic here
                //cate.CreateTime = DateTime.Today;
                this.cateManager.SaveCate(cate);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}