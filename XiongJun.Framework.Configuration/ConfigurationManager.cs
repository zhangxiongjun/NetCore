using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace XiongJun.Framework.Configuration
{
    public class ConfigurationManager
    {
        public static T GetAppSetting<T>(string key,string jsonName) where T : class, new()
        {
            //获取json文件的路径
            var baseDir = AppContext.BaseDirectory+"Config";
            IConfiguration configuration=new ConfigurationBuilder()
                .SetBasePath(baseDir)
                .Add(new JsonConfigurationSource { Path = jsonName + ".json", Optional = false, ReloadOnChange = true })
                .Build();
            var appconfig = new ServiceCollection()
                .AddOptions()
                .Configure<T>(configuration.GetSection(key))
                .BuildServiceProvider()
                .GetService<IOptions<T>>()
                .Value;
            return appconfig;
        }
    }
}
