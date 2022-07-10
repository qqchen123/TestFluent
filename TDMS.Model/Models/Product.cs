using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMS.Model.Models
{
    public class Product
    {
        public Product() {
            Orders = new List<Order>();
        }

        public virtual int ProductId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Cost { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}
