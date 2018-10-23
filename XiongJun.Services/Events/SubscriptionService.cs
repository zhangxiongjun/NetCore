using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiongJun.Framework.Core.Infrastructure;

namespace XiongJun.Services.Events
{
    public class SubscriptionService : ISubscriptionService
    {
        public IList<IConsumer<T>> GetSubscriptions<T>()
        {
            return EngineContext.Current.ResolveAll<IConsumer<T>>().ToList();
        }
    }
}
