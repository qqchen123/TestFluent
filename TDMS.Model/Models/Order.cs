using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMS.Model.Models
{
    public class Order
    {
        public Order() {
            Products = new List<Product>();
        }
        public virtual int OrderId { get; set; }
        public virtual string OrderDate { get; set; }
        //public virtual int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
