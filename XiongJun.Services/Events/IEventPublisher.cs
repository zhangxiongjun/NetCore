using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Services.Events
{
    /// <summary>
    /// 发布订阅模式
    /// </summary>
    public interface IEventPublisher
    {
        /// <summary>
        /// Publish event
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="eventMessage">Event message</param>
        void Publish<T>(T eventMessage);
    }
}
