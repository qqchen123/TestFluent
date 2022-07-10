using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFluent.Models;

namespace TestFluent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //using (var session = NHibernateHelper.OpenSession())
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {
            //        var projectInfo = session.QueryOver<ProjectInfo>();
            //        transaction.Commit();
            //        var proList = projectInfo.List();
            //    }
            //}

            //using (var session = NHibernateHelper.OpenSession())
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {
            //        var projectInfo = session.QueryOver<Product>();
            //        transaction.Commit();
            //        var proList = projectInfo.List();
            //    }
            //}
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