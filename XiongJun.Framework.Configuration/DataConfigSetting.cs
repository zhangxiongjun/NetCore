using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Framework.Configuration
{
    public class DataConfigSetting
    {
        /// <summary>
        /// SQL数据库连接配置
        /// </summary>
        public string SqlDataConnectionString { get; set; }
        
        public string MySqlDataConnectionString { get; set; }

        public bool RedisCachingEnabled { get; set; }
        public  string RedisCachingConnectionString { get; set; }
    }
}
