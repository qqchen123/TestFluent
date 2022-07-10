using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestFluent.Models;

namespace TestFluent.Manager
{
    public class CateManager
    {
        public IList<Cate> GetAllCate()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var cateList = session.QueryOver<Cate>();
                    transaction.Commit();
                    return cateList.List();
                }
            }
        }
        public IList<Cate> GetAllCateByLike(string condition)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var listRes = session.CreateCriteria<Cate>().Add(Restrictions.Like("CateName", condition+"%"));
                    return listRes.List<Cate>();
                }
            }
        }

        public IList<Cate> GetAllCateByEq(string condition)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var listRes = session.CreateCriteria<Cate>()
                        .Add(Restrictions.Eq("CateName", condition))
                        .List<Cate>();
                    return listRes;
                }
            }
        }

        public IList<Cate> GetAllCateByQueryOver(string condition)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var listRes = session.QueryOver<Cate>()
                        .Where(x=>x.CateName==condition)
                        .List<Cate>();
                    return listRes;
                }
            }
        }

        public IList<Cate> GetAllCateByLinq(string condition)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var listRes = session.Query<Cate>()
                        .Where(x => x.CateName == condition)
                        .ToList();
                    return listRes;
                }
            }
        }



        /// <summary>
        /// 保存cate数据
        /// </summary>
        /// <param name="cate"></param>
        public void SaveCate(Cate cate)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(cate);
                    transaction.Commit();
                }
            }
        }
    }
}