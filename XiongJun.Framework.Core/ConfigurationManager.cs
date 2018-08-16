using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace XiongJun.Framework.Core
{
    public class ConfigurationManager
    {
        public T GetAppSettingConfiguration<T>(string key) where T : class, new()
        {
         
            return default(T);
        }
    }
}
