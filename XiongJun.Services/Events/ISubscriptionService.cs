using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Services.Events
{
    /// <summary>
    /// 事件订阅服务
    /// </summary>
    public interface ISubscriptionService
    {
        /// <summary>
        /// 获取所有的订阅者
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IList<IConsumer<T>> GetSubscriptions<T>();
    }
}
