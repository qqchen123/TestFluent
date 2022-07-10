using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMS.Model.Models;

namespace TDMS.Model.Mapping
{
    class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.OrderId).Column("ORDERID").GeneratedBy.Sequence("SEQ_SHOP_ORDERID");
            Map(x => x.OrderDate).Column("ORDERDATE");
            HasManyToMany<Product>(m=>m.Products).ParentKeyColumn("ORDERID").ChildKeyColumn("PRODUCTID").Table("SHOP_ORDERPRODUCT");
            Table("SHOP_ORDER");
        }
    }
}
