using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserManager
    {
        bool Login(string email, string password);
        List<PostDTO> PostStream();
        List<PostDTO> GetPostsOfSelectedUser(ObjectId user_posts);
        List<UserDTO> AllUsers();
        List<UserDTO> UsersByFirstName(string firstName);
        List<UserDTO> UsersByLastName(string lastName);
        void AddFriend(ObjectId id_user, ObjectId id_currentUserMe);
        void DeleteFriend(ObjectId id_user, ObjectId id_currentUserMe);
        void SubscribeToUser(ObjectId id_user, ObjectId id_currentUserMe);
        void UnSubscribeToUser(ObjectId id_user, ObjectId id_currentUserMe);
        void AddLikeToPost(ObjectId id_post, ObjectId user);
        void DeleteLikeToPost(ObjectId id_post, ObjectId user);
        void AddCommentToPost(ObjectId id_post, ObjectId user, string text);
        void DeleteCommentToPost(ObjectId id_post, ObjectId user, string text);
        ObjectId GetIdOfCurrentUser(string email, string password, string name_for_cache);
        PostDTO GetPostById(ObjectId id_post);
        UserDTO GetUserById(ObjectId id_user);
        void ClearCache();
        int CommonPeople(ObjectId id_user, ObjectId id_currentUserMe);
        bool IsFriends(ObjectId id_user, ObjectId id_currentUserMe);
    }
}
