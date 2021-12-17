using BLL.Concrete;
using DAL.Cache.Concrete;
using DAL.Concrete;
using DAL.Interfaces;
using DAL.Neo4j.Concrete;
using MongoDB.Driver;
using Neo4jClient;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDependencies
{
    public class Dependencies
    {
        public static BoltGraphClient client_n4j = new BoltGraphClient(new Uri("http://localhost:7474"), "neo4j", "admin");

        static UserDALNeo4j user_ngj = new UserDALNeo4j(client_n4j);


        public static ConnectionMultiplexer conn_cache = ConnectionMultiplexer.Connect("localhost:12000,abortConnect=false, ,allowAdmin=true");
        public static IDatabase db_cache = conn_cache.GetDatabase();

        static RedisCacheDAL _cacheDAL= new RedisCacheDAL(conn_cache, db_cache);

        public static MongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("SocialNetwork");

        static UserDAL _userDal = new UserDAL(db);
        static PostDAL _postDal = new PostDAL(db);

        public readonly UserManager manager = new UserManager(_userDal, _postDal, _cacheDAL, user_ngj);
    }
}
