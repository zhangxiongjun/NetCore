using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Framework.Core.Infrastructure
{
    public interface IEngine
    {
        /// <summary>
        /// 初始化Engine
        /// </summary>
        /// <param name="services">服务集</param>
        void Initialize(IServiceCollection services);

        /// <summary>
        /// Add and configure services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration);

        /// <summary>
        /// 配置HTTP请求管道
        /// </summary>
        /// <param name="application"></param>
        void ConfigureRequestPipeline(IApplicationBuilder application);

        /// <summary>
        /// Resolve dependency
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>() where T : class;

        object Resolve(Type type);

        IEnumerable<T> ResolveAll<T>();

        object ResolveUnregistered(Type type);
    }
}
