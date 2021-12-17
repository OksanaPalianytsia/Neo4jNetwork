using DAL.Cache.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Cache.Concrete
{
    public class RedisCacheDAL : IRedisCacheDAL
    {
        private ConnectionMultiplexer _conn;
        private IDatabase _cache_db;

        public RedisCacheDAL(ConnectionMultiplexer conn, IDatabase db)
        {
            _conn = conn;
            _cache_db = db;
        }

        public void ClearCache()
        {
            var endpoints = _conn.GetEndPoints();
            var server = _conn.GetServer(endpoints.First());
            server.FlushDatabase();
        }

        public string GetValueFromCache(string key)
        {
            return _cache_db.StringGet(key);
        }

        public bool IfKeyExists(string key)
        {
            return _cache_db.KeyExists(key);
        }

        public void RemoveFromCacheByKey(string key)
        {
            _cache_db.KeyDelete(key);
        }

        public void SaveIntoCache(string key, string value)
        {
            var ts = TimeSpan.FromMinutes(15);
            _cache_db.StringSet(key, value, ts);
        }
    }
}
