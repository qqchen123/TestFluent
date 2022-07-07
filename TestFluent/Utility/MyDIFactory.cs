﻿using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;

namespace TestFluent.Utility
{
    public class MyDIFactory
    {
        private static IUnityContainer _container = new UnityContainer();
        /// <summary>
        /// 执行且执行一次
        /// </summary>
        static MyDIFactory() 
        {
            //var container = new UnityContainer();
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "ConfigFiles\\unity.config");
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
            section.Configure(_container, "IQueryContainer");
        }

        public static IUnityContainer getContainer()
        {
            return _container;
        }
    }
}