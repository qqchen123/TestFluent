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
        public string DoMyTest()
        {
            CateManager cateManager = new CateManager();
            var proRes = cateManager.GetProduct();
            return "this is a test function ";
        }

        public IList<Cate> GetAllCate()
        {
            CateManager cateManager = new CateManager();
            return cateManager.GetAllCate();
        }

        public void SaveCate(Cate cate)
        {
            CateManager cateManager = new CateManager();
            cateManager.SaveCate(cate);
        }
    }
}
