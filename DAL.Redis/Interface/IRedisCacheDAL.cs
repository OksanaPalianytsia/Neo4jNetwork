using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Redis.Interface
{
    public interface  IRedisCacheDAL
    {
        bool IfKeyExists(string key);
        string GetValueFromCache(string key);
        void RemoveValueFromCache(string key);
        void ClearCache();
        void Save(string key, string value);
    }
}
