using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDMS.Model.Models;

namespace TDMS.Model.Manager
{
    public class ProjectInfoManager
    {
        /// <summary>
        /// 获取全部项目信息
        /// </summary>
        /// <returns></returns>
        public IList<ProjectInfo> GetAllProjectInfo()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var projectInfoList = session.QueryOver<ProjectInfo>();
                    transaction.Commit();
                    return projectInfoList.List();
                }
            }
        }

        /// <summary>
        /// 根据projectName搜索项目信息
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public IList<ProjectInfo> GetProjectByProjectName(string projectName)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var projectInfoList = session.QueryOver<ProjectInfo>().Where(x => x.ProjectName == projectName);
                    transaction.Commit();
                    return projectInfoList.List();
                }
            }
        }

        /// <summary>
        /// 根据id查询项目详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProjectInfo GetProjectByProjectName(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var projectInfo = session.Get<ProjectInfo>(id);
                    transaction.Commit();
                    return projectInfo;
                }
            }
        }

        /// <summary>
        /// 保存项目信息
        /// </summary>
        /// <param name="projectInfo"></param>
        public void SaveProjectInfo(ProjectInfo projectInfo)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(projectInfo);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// 根据id删除项目信息
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    ProjectInfo projectInfo = new ProjectInfo();
                    projectInfo.ProId = id;
                    session.Delete(projectInfo);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// 修改项目数据
        /// </summary>
        /// <param name="projectInfo"></param>
        public void UpdateUser(ProjectInfo projectInfo)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(projectInfo);
                    transaction.Commit();
                }
            }
        }


















    }
}