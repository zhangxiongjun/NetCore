using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using StackExchange.Redis;

namespace XiongJun.Framework.Cache.RedisCache
{
    public class RedisConnectionWrapper : IRedisConnectionWrapper
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void FlushDatabase(int? db = null)
        {
            throw new NotImplementedException();
        }

        public IDatabase GetDatabase(int? db = null)
        {
            throw new NotImplementedException();
        }

        public EndPoint[] GetEndPoints()
        {
            throw new NotImplementedException();
        }

        public IServer GetServer(EndPoint endPoint)
        {
            throw new NotImplementedException();
        }

        public bool PerformActionWithLock(string resource, TimeSpan expirationTime, Action action)
        {
            throw new NotImplementedException();
        }
    }
}
