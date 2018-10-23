using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace XiongJun.Web.MiddleWare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            var configer=new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();
            var builder=new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(configer)
                .UseStartup<Startup>()
                .UseKestrel(options=>options.Limits.MaxRequestBodySize=10*1024)
                .UseUrls("http://localhost:50824/").Build();
            builder.Run();
            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
