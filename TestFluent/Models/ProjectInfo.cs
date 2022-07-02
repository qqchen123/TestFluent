using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFluent.Models
{
    public class ProjectInfo
    {
        public virtual int ProId { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual string Pmo { get; set; }
        public virtual string Sponsor { get; set; }
        public virtual string Technology { get; set; }
        public virtual string Customer { get; set; }
        public virtual string Application { get; set; }
        public virtual string KeyWords { get; set; }
        public virtual string FilePath { get; set; }
        public virtual string M0Status { get; set; }
        public virtual string M0Time { get; set; }
        public virtual string T0Status { get; set; }
        public virtual string T0Time { get; set; }
    }
}