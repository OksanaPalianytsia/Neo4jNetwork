using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Cache.Interfaces
{
    public interface IRedisCacheDAL
    {
        bool IfKeyExists(string key);
        void SaveIntoCache(string key, string value);
        string GetValueFromCache(string key);
        void RemoveFromCacheByKey(string key);
        void ClearCache();

    }
}
