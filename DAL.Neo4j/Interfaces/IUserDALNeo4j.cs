using DTO.Neo4j;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Neo4j.Interfaces
{
    public interface IUserDALNeo4j
    {
        void AddNewUser(string email, string password);
        void AddNewRelation(string email_1, string password_1, string email_2, string password_2);
        void DeleteRelation(string email_1, string password_1, string email_2, string password_2);
        void DeleteUser(string email, string password);
        UserDTONeo4j GetUserByCredentials(string email, string password);
        List<UserDTONeo4j> GetAllUsers();
        bool IsFriends(string email_1, string password_1, string email_2, string password_2);
        int PathToUser(string email_1, string password_1, string email_2, string password_2);

    }
}
