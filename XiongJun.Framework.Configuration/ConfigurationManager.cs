using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace XiongJun.Framework.Configuration
{
    public class ConfigurationManager
    {
        public T GetAppSetting<T>(string key) where T : class, new()
        {
            var baseDir = AppContext.BaseDirectory;
            IConfiguration configuration=new ConfigurationBuilder()
                .SetBasePath(baseDir)
                .Add(new JsonConfigurationSource { Path = "appsettings.json", Optional = false, ReloadOnChange = true })
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
