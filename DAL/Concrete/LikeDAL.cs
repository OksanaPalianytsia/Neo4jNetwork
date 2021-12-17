using DAL.Interfaces;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class LikeDAL : ILikeDAL
    {
        IMongoDatabase db;
        public LikeDAL(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public void AddNewLike(ObjectId user)
        {
            LikeDTO like = new LikeDTO(user);
            var collection = db.GetCollection<LikeDTO>("likes");
            collection.InsertOne(like);
        }

        public void DeleteLike(ObjectId id_like)
        {
            var collection = db.GetCollection<LikeDTO>("likes");
            var filter = Builders<LikeDTO>.Filter.Eq("Id", id_like);
            collection.DeleteOne(filter);
        }

        public List<LikeDTO> GetAllLikes()
        {
            var collection = db.GetCollection<LikeDTO>("likes");
            return collection.Find(new BsonDocument()).ToList();
        }

        public LikeDTO GetLikeById(ObjectId id_like)
        {
            var collection = db.GetCollection<LikeDTO>("likes");
            var filter = Builders<LikeDTO>.Filter.Eq("Id", id_like);
            return collection.Find(filter).First();
        }

        [Obsolete]
        public void UpsertLike(ObjectId id_like, LikeDTO new_info_like)
        {
            var collection = db.GetCollection<LikeDTO>("likes");

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id_like),
                new_info_like,
                new UpdateOptions { IsUpsert = true });
        }
    }
}
