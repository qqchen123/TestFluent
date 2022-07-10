using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDMS.Model.Models;

namespace TDMS.Model.Manager
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


        public IList<Product> GetProduct()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var productRes = session.CreateCriteria<Product>().List<Product>();
                    transaction.Commit();
                    return productRes;
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