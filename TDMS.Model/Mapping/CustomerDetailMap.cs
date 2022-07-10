using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMS.Model.Models;

namespace TDMS.Model.Mapping
{
    class CustomerDetailMap : ClassMap<CustomerDetail>
    {
        public CustomerDetailMap()
        {
            Id(x => x.CDID).Column("CDID").GeneratedBy.Sequence("SEQ_SHOP_CUSTOMERID");
            Map(x => x.ADDRESS).Column("ADDRESS");
            Map(x => x.PHONE).Column("PHONE");
            Map(x => x.EMAIL).Column("EMAIL");
            Map(x => x.CUSTOMERID).Column("CUSTOMERID");

            HasOne(x => x.Customer)
                .Cascade.All();

            Table("SHOP_CUSTOMER_DETAIL");
        }
    }
}
