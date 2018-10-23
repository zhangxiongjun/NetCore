using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace XiongJun.Framework.Core.Infrastructure
{
   public class Engine:IEngine
    {
        private IServiceProvider _serviceProvider { get; set; }
        public virtual IServiceProvider ServiceProvider => _serviceProvider;
        /// <summary>
        /// Get IServiceProvider
        /// </summary>
        /// <returns>IServiceProvider</returns>
        protected IServiceProvider GetServiceProvider()
        {
            var accessor = ServiceProvider.GetService<IHttpContextAccessor>();
            var context = accessor.HttpContext;
            return context?.RequestServices ?? ServiceProvider;
        }

        public void Initialize(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        public void ConfigureRequestPipeline(IApplicationBuilder application)
        {
            throw new NotImplementedException();
        }

        public T Resolve<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public object Resolve(Type type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            throw new NotImplementedException();
        }

        public object ResolveUnregistered(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
