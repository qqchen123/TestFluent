using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMS.Model.Models
{
    public class CustomerDetail
    {
        public virtual int CDID { get; set; }
        public virtual string ADDRESS { get; set; }
        public virtual string PHONE { get; set; }
        public virtual string EMAIL { get; set; }
        public virtual int CUSTOMERID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
