using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Framework.Configuration
{
    public class RedisConfig
    {
        public bool RedisCachingEnabled { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Password { get; set; }
        public int ConnectTimeout { get; set; }
        public int ConnectRetry { get; set; }
        public int SyncTimeout { get; set; }
    }
}
