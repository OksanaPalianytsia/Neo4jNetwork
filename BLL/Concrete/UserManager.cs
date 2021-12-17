using BLL.Interfaces;
using DAL.Cache.Interfaces;
using DAL.Interfaces;
using DAL.Neo4j.Interfaces;
using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDAL _userDal;
        private readonly IPostDAL _postDal;
        private readonly IRedisCacheDAL _cacheDal;
        private readonly IUserDALNeo4j _user_Neo4j_DAL;

        public UserManager(IUserDAL userDal, IPostDAL postDal, IRedisCacheDAL cacheDAL, IUserDALNeo4j user_Neo4j)
        {
            _userDal = userDal;
            _postDal = postDal;
            _cacheDal = cacheDAL;
            _user_Neo4j_DAL = user_Neo4j;

        }
        public void AddCommentToPost(ObjectId id_post, ObjectId user, string text)
        {
            _postDal.AddCommentToPost(id_post, user, text);
        }

        public void AddFriend(ObjectId id_user, ObjectId id_currentUserMe)
        {
            UserDTO user_1 = new UserDTO();
            UserDTO user_2 = new UserDTO();
            user_1 = _userDal.GetUserById(id_user);
            user_2 = _userDal.GetUserById(id_currentUserMe);
            _user_Neo4j_DAL.AddNewRelation(user_1.Email, user_1.Password, user_2.Email, user_2.Password);

            _userDal.AddFriend(id_user, id_currentUserMe);
        }

        public void AddLikeToPost(ObjectId id_post, ObjectId user)
        {
            _postDal.AddLikeToPost(id_post, user);
        }

        public List<UserDTO> AllUsers()
        {
            return _userDal.GetAllUsers();
        }

        public void ClearCache()
        {
             _cacheDal.ClearCache();
        }

        public int CommonPeople(ObjectId id_user, ObjectId id_currentUserMe)
        {
            UserDTO user_1 = new UserDTO();
            UserDTO user_2 = new UserDTO();
            user_1 = _userDal.GetUserById(id_user);
            user_2 = _userDal.GetUserById(id_currentUserMe);
            return _user_Neo4j_DAL.PathToUser(user_1.Email, user_1.Password, user_2.Email, user_2.Password);
        }

        public void DeleteCommentToPost(ObjectId id_post, ObjectId user, string text)
        {
            _postDal.DeleteCommentToPost(id_post, user, text);
        }

        public void DeleteFriend(ObjectId id_user, ObjectId id_currentUserMe)
        {
            UserDTO user_1 = new UserDTO();
            UserDTO user_2 = new UserDTO();
            user_1 = _userDal.GetUserById(id_user);
            user_2 = _userDal.GetUserById(id_currentUserMe);
            _user_Neo4j_DAL.DeleteRelation(user_1.Email, user_1.Password, user_2.Email, user_2.Password);

            _userDal.DeleteFriend(id_user, id_currentUserMe);
        }

        public void DeleteLikeToPost(ObjectId id_post, ObjectId user)
        {
            _postDal.DeleteLikeToPost(id_post, user);
        }

        public ObjectId GetIdOfCurrentUser(string email, string password, string name_for_cache)
        {
            var result = _userDal.GetIdOfCurrentUser(email, password);
            //if (!_cacheDal.IfKeyExists($"key{name_for_cache}"))
            //{
            //    _cacheDal.SaveIntoCache($"key{name_for_cache}", result.ToString());
            //}            
            return result;
        }

        public PostDTO GetPostById(ObjectId id_post)
        {
            return _postDal.GetPostById(id_post);
        }

        public List<PostDTO> GetPostsOfSelectedUser(ObjectId user_posts)
        {
            return _postDal.GetPostsOfCertainUser(user_posts);
        }

        public UserDTO GetUserById(ObjectId id_user)
        {
            return _userDal.GetUserById(id_user);
        }

        public bool IsFriends(ObjectId id_user, ObjectId id_currentUserMe)
        {
            UserDTO user_1 = new UserDTO();
            UserDTO user_2 = new UserDTO();
            user_1 = _userDal.GetUserById(id_user);
            user_2 = _userDal.GetUserById(id_currentUserMe);
            return _user_Neo4j_DAL.IsFriends(user_1.Email, user_1.Password, user_2.Email, user_2.Password);
        }

        public bool Login(string email, string password)
        {
            return _userDal.Login(email, password);
        }

        public List<PostDTO> PostStream()
        {
            var posts = _postDal.SortPostsByInsertData();
            //int i = 0;
            //foreach (var el in posts)
            //{
            //    if (!_cacheDal.IfKeyExists($"keyStreamPost{i}"))
            //    {
            //        _cacheDal.SaveIntoCache($"keyStreamPost{i}", el.Id.ToString());
            //        i++;
            //    }
            //    else 
            //    {
            //        break;
            //    }
            //}
            return posts;
        }

        public void SubscribeToUser(ObjectId id_user, ObjectId id_currentUserMe)
        {
            _userDal.SubscribeToUser(id_user, id_currentUserMe);
        }

        public void UnSubscribeToUser(ObjectId id_user, ObjectId id_currentUserMe)
        {
            _userDal.UnSubscribeToUser(id_user, id_currentUserMe);
        }

        public List<UserDTO> UsersByFirstName(string firstName)
        {
            return _userDal.FindUserByFirstName(firstName);
        }

        public List<UserDTO> UsersByLastName(string lastName)
        {
            return _userDal.FindUserByLastName(lastName);
        }
    }
}
