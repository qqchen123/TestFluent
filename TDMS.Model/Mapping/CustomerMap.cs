using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMS.Model.Models;

namespace TDMS.Model.Mapping
{
    class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.CustomerId).Column("CUSTOMERID").GeneratedBy.Sequence("SEQ_SHOP_CUSTOMERID");
            Map(x => x.FirstName).Column("FIRSTNAME");
            Map(x => x.LastName).Column("LASTNAME");
            HasOne(x => x.CustomerDetail)
                .Cascade.All()
                .PropertyRef("CUSTOMERID");

            HasMany<Order>(x => x.Orders)
                .Not.LazyLoad()
                .Cascade.All()
                .Inverse()
                .KeyColumn("CUSTOMERID");
            Table("SHOP_CUSTOMER");
        }
    }
}
