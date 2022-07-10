using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMS.Model.Models;

namespace TDMS.Interface
{
    public interface IProjectInfoService
    {
         string DoMyTest();
         IList<Cate> GetAllCate();
        void SaveCate(Cate cate);

        IList<Product> getAllProduct();

        Customer GetCustomer();
    }
}
