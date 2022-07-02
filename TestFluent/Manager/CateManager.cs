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