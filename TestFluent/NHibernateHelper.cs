using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using TestFluent.Models;
using FluentNHibernate.Automapping;

namespace TestFluent
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
        private static void InitializeSessionFactory() {
            string connectionString = "User ID=wateruser;Password=itcast;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.80.10)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = orcl)))";
            _sessionFactory = Fluently.Configure()
                .Database(
                     OracleManagedDataClientConfiguration.Oracle10 
                     //OracleClientConfiguration.Oracle10
                     .ConnectionString(connectionString)
                     .Provider<NHibernate.Connection.DriverConnectionProvider>()
                     .Driver<NHibernate.Driver.OracleManagedDataClientDriver>()
                 )
                .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(ProjectInfo).Assembly))
                .BuildSessionFactory();
        }
        
        public static ISession OpenSession() {
            return SessionFactory.OpenSession();
        }
    }
}