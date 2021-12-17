using DAL.Redis.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Redis.Concrete
{
    public class RedisCacheDAL : IRedisCacheDAL
    {
        private readonly ISettings _settings;
        private readonly IDatabase _cache;
        private static ConnectionMultiplexer _connectionMultiplexer;

        static RedisCacheService()
        {
            var connection = ConfigurationManager.AppSettings["RedisConnection"];
            _connectionMultiplexer = ConnectionMultiplexer.Connect(connection);
        }
        public void ClearCache()
        {
            throw new NotImplementedException();
        }

        public string GetValueFromCache(string key)
        {
            throw new NotImplementedException();
        }

        public bool IfKeyExists(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveValueFromCache(string key)
        {
            throw new NotImplementedException();
        }

        public void SaveToCache(string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}
