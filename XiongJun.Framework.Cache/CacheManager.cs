using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace XiongJun.Framework.Cache
{
    public class CacheManager:ICacheManager
    {
        #region Fields

        private readonly ICacheManager _perRequestCacheManager;

        private readonly IDatabase _db;

        #endregion


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object data, int cacheTime)
        {
            throw new NotImplementedException();
        }

        public bool IsSet(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveByPattern(string pattern)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
