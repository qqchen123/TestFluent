﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMS.Model.Models
{
    public class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual ISet<Order> Orders { get; set; }

        public virtual CustomerDetail CustomerDetail { get; set; }
    }
}
