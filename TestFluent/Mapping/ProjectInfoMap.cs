using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using TestFluent.Models;

namespace TestFluent.Mapping
{
    public class ProjectInfoMap:ClassMap<ProjectInfo>
    {
        public ProjectInfoMap() {
            Id(x=>x.ProId).Column("PRO_ID").GeneratedBy.Sequence("SEQ_TDMS_PROCEDURE_INFO");
            Map(x=>x.ProjectName).Column("PROJECT_NAME");
            Map(x=>x.Pmo).Column("PMO");
            Map(x=>x.Sponsor).Column("SPONSOR");
            Map(x=>x.Technology).Column("TECHNOLOGY");
            Map(x=>x.Customer).Column("CUSTOMER");
            Map(x=>x.Application).Column("APPLICATION");
            Map(x=>x.FilePath).Column("FILE_PATH");
            Map(x=>x.M0Status).Column("M0_STATUS");
            Map(x=>x.M0Time).Column("M0_TIME");
            Map(x=>x.T0Status).Column("T0_STATUS");
            Map(x=>x.T0Time).Column("T0_TIME");
            Table("TDMS_PROJECT_INFO");
        }
    }
}