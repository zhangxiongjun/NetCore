using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XiongJun.Services.Events
{
    public class EventPublisher : IEventPublisher
    {
        private readonly ISubscriptionService _subscriptionService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="subscriptionService"></param>
        public EventPublisher(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        /// <summary>
        /// 发布消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="eventMessage"></param>
        public void Publish<T>(T eventMessage)
        {
            //获取所有的消息订阅者
            var subscriptions = _subscriptionService.GetSubscriptions<T>().ToList();
            //轮询推送消息给订阅者
            subscriptions.ForEach(sub=>PublishToConsumer(sub, eventMessage));
        }

        /// <summary>
        /// 推送消息给订阅者
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="eventMessage"></param>
        protected virtual void PublishToConsumer<T>(IConsumer<T> x, T eventMessage)
        {
            x.HandleEvent(eventMessage);
        }
    }
}
