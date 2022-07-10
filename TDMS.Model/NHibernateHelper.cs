﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using TDMS.Model.Models;
using FluentNHibernate.Automapping;
using System.Configuration;

namespace TDMS.Model
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }
        private static void InitializeSessionFactory()
        {
            string connectionString = "User ID=wateruser;Password=itcast;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.80.10)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl)))";
            //string connectionString = ConfigurationManager.ConnectionStrings["OracleConnstr"].ConnectionString; // ConfigurationManager.AppSettings["OracleConnstr"];
            _sessionFactory = Fluently.Configure()
                .Database(
                     OracleManagedDataClientConfiguration.Oracle10
                     //OracleClientConfiguration.Oracle10
                     .ConnectionString(connectionString)
                     .Provider<NHibernate.Connection.DriverConnectionProvider>()
                     .Driver<NHibernate.Driver.OracleManagedDataClientDriver>()
                 )
                .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(ProjectInfo).Assembly))
                .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(Cate).Assembly))
                .BuildSessionFactory();
        }
        
        public static ISession OpenSession() {
            return SessionFactory.OpenSession();
        }
    }
}