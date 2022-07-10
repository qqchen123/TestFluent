using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMS.Model.Models;

namespace TDMS.Model.Mapping
{
    class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.ProductId).Column("PRODUCTID").GeneratedBy.Sequence("SEQ_SHOP_PRODUCTID");
            Map(x => x.Name).Column("NAME");
            Map(x => x.Cost).Column("COST");
            HasManyToMany<Order>(m => m.Orders)
                .ParentKeyColumn("PRODUCTID")
                .ChildKeyColumn("ORDERID")
                .Table("SHOP_ORDERPRODUCT")
                .Not.LazyLoad();
            Table("SHOP_PRODUCT");
        }
    }
}
