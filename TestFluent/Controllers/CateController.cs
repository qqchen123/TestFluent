using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMS.Interface;
using TestFluent.Manager;
using TestFluent.Models;
using TestFluent.Utility;
using Unity;

namespace TestFluent.Controllers
{
    public class CateController : Controller
    {
        CateManager cateManager;
        public CateController()
        {
            this.cateManager = new CateManager();
        }

        public ActionResult Test() {
            IUnityContainer container = MyDIFactory.getContainer();
            IProjectInfoService project = container.Resolve<IProjectInfoService>();
            string proRes = project.DoMyTest();
            return Content(proRes);
        }

        // GET: Cate
        public ActionResult Index()
        {
           var  CurrentUser1 = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            string[] Cuser1 = CurrentUser1.Split('\\');
            IList<Cate> cateList = this.cateManager.GetAllCate();
            var myCate = cateList.Where(r => r.CateId > 100);
            ViewBag.cateList = myCate;
            //IList<Cate> cateList = this.cateManager.GetAllCateByLike("2");
            //ViewBag.cateList = cateList;
            return View();
        }

        // GET: Cate
        public ActionResult CateEq()
        {
            //IList<Cate> cateList = this.cateManager.GetAllCate();
            //ViewBag.cateList = cateList;
            IList<Cate> cateList = this.cateManager.GetAllCateByEq("T2");
            return Content(cateList.ToString());
        }

        // GET: Cate
        public ActionResult CateQO()
        {
            //IList<Cate> cateList = this.cateManager.GetAllCate();
            //ViewBag.cateList = cateList;
            IList<Cate> cateList = this.cateManager.GetAllCateByQueryOver("T2");
            return Content(cateList.ToString());
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