using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFluent.Models
{
    public class Cate
    {
        public virtual int CateId { get; set; }
        public virtual string CateName { get; set; }
        public virtual string ParentId { get; set; }
        public virtual string IsDelete { get; set; }
        public virtual string TableInfo { get; set; }
        public virtual string CreateTime { get; set; }
        public virtual string UpdateTime { get; set; }
    }
}