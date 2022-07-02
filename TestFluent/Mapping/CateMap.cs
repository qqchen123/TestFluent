using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestFluent.Models;

namespace TestFluent.Mapping
{
    public class CateMap:ClassMap<Cate>
    {
        public CateMap()
        {
            Id(x => x.CateId).Column("CATE_ID").GeneratedBy.Sequence("SEQ_TDMS_PROCEDURE_CATE");
            Map(x => x.CateName).Column("CATE_NAME");
            Map(x => x.TableInfo).Column("TABLE_INFO");
            Map(x => x.ParentId).Column("PARENT_ID");
            Map(x => x.IsDelete).Column("IS_DELETE");
            Map(x => x.CreateTime).Column("CREATE_TIME");
            Map(x => x.UpdateTime).Column("UPDATE_TIME");
            Table("TDMS_PROCEDURE_CATE");
        }
    }
}