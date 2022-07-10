using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMS.Interface;
using TDMS.Model.Manager;
using TDMS.Model.Models;

namespace TDMS.Service
{
    public class ProjectInfoService : IProjectInfoService
    {
        CateManager cateManager = null;
        public ProjectInfoService() {
            this.cateManager = new CateManager();
        }

        public string DoMyTest()
        {
            var proRes = this.cateManager.GetProduct();
            return "this is a test function ";
        }

        public IList<Cate> GetAllCate()
        {
            return this.cateManager.GetAllCate();
        }

        /// <summary>
        /// 关联查询----获取产品和订单信息
        /// </summary>
        /// <returns></returns>
        public IList<Product> getAllProduct()
        {
            return this.cateManager.GetProduct();
        }

        public Customer GetCustomer()
        {
            return this.cateManager.GetCustomer();
        }

        public void SaveCate(Cate cate)
        {
            CateManager cateManager = new CateManager();
            cateManager.SaveCate(cate);
        }
    }
}
