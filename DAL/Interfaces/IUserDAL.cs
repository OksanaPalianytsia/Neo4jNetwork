using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserDAL
    {
        bool Login(string email, string password);
        List<UserDTO> FindUserByFirstName(string firstName);
        List<UserDTO> FindUserByLastName(string lastName);
        void SubscribeToUser(ObjectId id_user, ObjectId id_follower);
        void UnSubscribeToUser(ObjectId id_user, ObjectId id_follower);
        void AddFriend(ObjectId id_user, ObjectId id_me);
        void DeleteFriend(ObjectId id_user, ObjectId id_me);
        void CreateOwnPost(ObjectId id_user, PostDTO post);
        void DeleteOwnPost(ObjectId id_user, ObjectId post_id);
        UserDTO GetUserById(ObjectId id_user);
        void AddNewUser(UserDTO user);
        void DeleteUser(ObjectId id_user);
        List<UserDTO> GetAllUsers();
        void UpsertUser(ObjectId id_user, UserDTO new_info_user);
        ObjectId GetIdOfCurrentUser(string email, string password);
    }
}
