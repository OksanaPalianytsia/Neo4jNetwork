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
    public class PostDAL : IPostDAL
    {
        IMongoDatabase db;
        public PostDAL(IMongoDatabase database)
        {
            var client = new MongoClient();
            db = database;
        }
        public void AddCommentToPost(ObjectId id_post, ObjectId user, string text)
        {
            CommentDTO comment = new CommentDTO(user, text);
            var collection = db.GetCollection<PostDTO>("posts");
            var condition = Builders<PostDTO>.Update.AddToSet("comments", comment);
            collection.UpdateOne(s => s.Id == id_post, condition);
        }

        public void AddLikeToPost(ObjectId id_post, ObjectId user)
        {
            LikeDTO like = new LikeDTO(user);
            var collection = db.GetCollection<PostDTO>("posts");
            var condition = Builders<PostDTO>.Update.AddToSet("likes", like);
            collection.UpdateOne(s => s.Id == id_post, condition);
        }

        public void AddNewPost(PostDTO post)
        {
            var collection = db.GetCollection<PostDTO>("posts");
            collection.InsertOne(post);
        }

        public void DeleteCommentToPost(ObjectId id_post, ObjectId user, string text)
        {
            var collection = db.GetCollection<PostDTO>("posts");
            var condition = Builders<PostDTO>.Update.PullFilter(x => x.Comments, Builders<CommentDTO>.Filter.Eq("user", user) & Builders<CommentDTO>.Filter.Eq("text", text));
            collection.UpdateOne(s => s.Id == id_post, condition);
        }

        public void DeleteLikeToPost(ObjectId id_post, ObjectId user)
        {
            var collection = db.GetCollection<PostDTO>("posts");
            var condition = Builders<PostDTO>.Update.PullFilter(x => x.Likes, Builders<LikeDTO>.Filter.Eq("user", user));
            collection.UpdateOne(s => s.Id == id_post, condition);
        }

        public void DeletePost(ObjectId id_post)
        {
            var collection = db.GetCollection<PostDTO>("posts");
            var filter = Builders<PostDTO>.Filter.Eq("Id", id_post);
            collection.DeleteOne(filter);
        }

        public List<PostDTO> GetAllPosts()
        {
            var collection = db.GetCollection<PostDTO>("posts");
            return collection.Find(new BsonDocument()).ToList();
        }

        public PostDTO GetPostById(ObjectId id_post)
        {
            var collection = db.GetCollection<PostDTO>("posts");
            var filter = Builders<PostDTO>.Filter.Eq("Id", id_post);
            return collection.Find(filter).First();
        }

        public List<PostDTO> GetPostsOfCertainUser(ObjectId user_posts)
        {
            var collection = db.GetCollection<PostDTO>("posts");
            var filter = Builders<PostDTO>.Filter.Eq("postedby", user_posts);
            return collection.Find(filter).ToList();
        }

        public List<PostDTO> SortPostsByInsertData()
        {
            var collection = db.GetCollection<PostDTO>("posts");
            var cursor = collection.Find(_ =>true);
            cursor.SortByDescending(x => x.Id);
            return cursor.ToList();
        }

        [Obsolete]
        public void UpsertPost(ObjectId id_post, PostDTO new_info_post)
        {
            var collection = db.GetCollection<PostDTO>("posts");

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id_post),
                new_info_post,
                new UpdateOptions { IsUpsert = true });
        }
    }
}
