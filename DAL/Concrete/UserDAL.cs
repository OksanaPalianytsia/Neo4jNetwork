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
    public class UserDAL : IUserDAL
    {
        IMongoDatabase db;
        public UserDAL(IMongoDatabase database)
        {
            var client = new MongoClient();
            db = database;
        }

        public void AddFriend(ObjectId id_user, ObjectId id_me)
        {
            var me = new UserDTO();
            var friend = new UserDTO();
            me = GetUserById(id_me);
            friend = GetUserById(id_user);
            var collection = db.GetCollection<UserDTO>("users");
            var condition1 = Builders<UserDTO>.Update.AddToSet("friends", me);
            collection.UpdateOne(s => s.Id == id_user, condition1);
            var condition2 = Builders<UserDTO>.Update.AddToSet("friends", id_user);
            collection.UpdateOne(s => s.Id == id_me, condition2);
        }

        public void AddNewUser(UserDTO user)
        {
            var collection = db.GetCollection<UserDTO>("users");
            collection.InsertOne(user);
        }

        public void CreateOwnPost(ObjectId id_user, PostDTO post)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var condition = Builders<UserDTO>.Update.AddToSet("posts", post);
            collection.UpdateOne(s => s.Id == id_user, condition);
        }

        public void DeleteFriend(ObjectId id_user, ObjectId id_me)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var condition1 = Builders<UserDTO>.Update.PullFilter(x => x.Friends, Builders<UserDTO>.Filter.Where(y => y.Id == id_me));
            collection.UpdateOne(s => s.Id == id_user, condition1);
            var condition2 = Builders<UserDTO>.Update.PullFilter(x => x.Friends, Builders<UserDTO>.Filter.Where(y => y.Id == id_user));
            collection.UpdateOne(s => s.Id == id_me, condition1);
        }

        public void DeleteOwnPost(ObjectId id_user, ObjectId post_id)
        {
            var collection = db.GetCollection<UserDTO>("users");          
            var condition = Builders<UserDTO>.Update.PullFilter(x => x.Posts, Builders<PostDTO>.Filter.Where(y => y.Id == post_id));
            collection.UpdateOne(s => s.Id == id_user, condition);
        }

        public void DeleteUser(ObjectId id_user)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var filter = Builders<UserDTO>.Filter.Eq("Id", id_user);
            collection.DeleteOne(filter);
        }

        public List<UserDTO> FindUserByFirstName(string firstName)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var filter = Builders<UserDTO>.Filter.Eq("firstname", firstName);
            return collection.Find(filter).ToList();
        }

        public List<UserDTO> FindUserByLastName(string lastName)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var filter = Builders<UserDTO>.Filter.Eq("lastname", lastName);
            return collection.Find(filter).ToList();
        }

        public List<UserDTO> GetAllUsers()
        {
            var collection = db.GetCollection<UserDTO>("users");
            return collection.Find(_ => true).ToList();
        }

        public ObjectId GetIdOfCurrentUser(string email, string password)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var filter = Builders<UserDTO>.Filter.Eq("email", email) & Builders<UserDTO>.Filter.Eq("password", password);
            return  collection.Find(filter).ToList().First().Id;
        }

        public UserDTO GetUserById(ObjectId id_user)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var filter = Builders<UserDTO>.Filter.Eq("Id", id_user);
            return collection.Find(filter).First();
        }

        public bool Login(string email, string password)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var filter = Builders<UserDTO>.Filter.Eq("email", email) & Builders<UserDTO>.Filter.Eq("password", password);
            var result = collection.Find(filter).ToList();
            if (result.Count != 0)
            {
                return true;
            }
            else
            {
                return false; ;
            }
        }

        public void SubscribeToUser(ObjectId id_user, ObjectId id_follower)
        {
            var follower = new UserDTO();
            follower = GetUserById(id_follower);
            var collection = db.GetCollection<UserDTO>("users");
            var condition = Builders<UserDTO>.Update.AddToSet("subscribers", follower);
            collection.UpdateOne(s => s.Id == id_user, condition);
        }

        public void UnSubscribeToUser(ObjectId id_user, ObjectId id_follower)
        {
            var collection = db.GetCollection<UserDTO>("users");
            var condition = Builders<UserDTO>.Update.PullFilter(x => x.Subscribers, Builders<UserDTO>.Filter.Where(y => y.Id == id_follower));
            collection.UpdateOne(s => s.Id == id_user, condition);
        }

        [Obsolete]
        public void UpsertUser(ObjectId id_user, UserDTO new_info_user)
        {
            var collection = db.GetCollection<UserDTO>("users");

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id_user),
                new_info_user,
                new UpdateOptions { IsUpsert = true });
        }
    }
}
