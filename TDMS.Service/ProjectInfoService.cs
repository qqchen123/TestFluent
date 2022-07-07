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
            IList<Cate> cateList = cateManager.GetAllCate();
            return "this is a test function ";
        }
    }
}
