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
    public class CommentDAL : ICommentDAL
    {
        IMongoDatabase db;
        public CommentDAL(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public void AddNewComment(ObjectId user, string text)
        {
            CommentDTO comment = new CommentDTO(user, text);
            var collection = db.GetCollection<CommentDTO>("comments");
            collection.InsertOne(comment);
        }

        public void DeleteComment(ObjectId id_comment)
        {
            var collection = db.GetCollection<CommentDTO>("comments");
            var filter = Builders<CommentDTO>.Filter.Eq("Id", id_comment);
            collection.DeleteOne(filter);
        }

        public List<CommentDTO> GetAllComments()
        {
            var collection = db.GetCollection<CommentDTO>("comments");
            return collection.Find(new BsonDocument()).ToList();
        }

        public CommentDTO GetCommentById(ObjectId id_comment)
        {
            var collection = db.GetCollection<CommentDTO>("comments");
            var filter = Builders<CommentDTO>.Filter.Eq("Id", id_comment);
            return collection.Find(filter).First();
        }

        [Obsolete]
        public void UpsertComment(ObjectId id_comment, CommentDTO new_info_comment)
        {
            var collection = db.GetCollection<CommentDTO>("comments");

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id_comment),
                new_info_comment,
                new UpdateOptions { IsUpsert = true });
        }
    }
}
