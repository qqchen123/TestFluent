using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFluent.Manager;
using TestFluent.Models;

namespace TestFluent.Controllers
{
    public class ProjectInfoController : Controller
    {
        ProjectInfoManager projectInfoManager;
        public ProjectInfoController()
        {
            this.projectInfoManager = new ProjectInfoManager();
        }
        // GET: ProjectInfo
        public ActionResult Index()
        {
            IList<ProjectInfo> projectInfoList = this.projectInfoManager.GetAllProjectInfo();
            ViewBag.projectInfoList = projectInfoList;
            return View();
        }

        // GET: ProjectInfo/Details/5
        public ActionResult Details(int id)
        {
            var projectInfo = this.projectInfoManager.GetProjectByProjectName(id);
            ViewBag.projectInfo = projectInfo;
            return View();
        }

        // GET: ProjectInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectInfo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
