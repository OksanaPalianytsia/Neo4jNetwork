using DAL.Neo4j.Interfaces;
using DTO.Neo4j;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Neo4j.Concrete
{
    public class UserDALNeo4j : IUserDALNeo4j
    {
        BoltGraphClient client;
        public UserDALNeo4j(BoltGraphClient b)
        {
            client = b;
            client.Connect();
        }

        public void AddNewRelation(string email_1, string password_1, string email_2, string password_2)
        {

            client.Cypher
                .Match("(user1:UserDTONeo4j {email: {Email1}, password: {Password1}})","(user2:UserDTONeo4j {email: {Email2}, password: {Password2}})")
                .WithParam("Email1", email_1)
                .WithParam("Password1", password_1)
                .WithParam("Email2", email_2)
                .WithParam("Password2", password_2)
                .Create("(user1)-[:FRIENDS]->(user2)")
                .ExecuteWithoutResults();
            client.Cypher
                .Match("(user1:UserDTONeo4j {email: {Email1}, password: {Password1}})", "(user2:UserDTONeo4j {email: {Email2}, password: {Password2}})")
                .WithParam("Email1", email_1)
                .WithParam("Password1", password_1)
                .WithParam("Email2", email_2)
                .WithParam("Password2", password_2)
                .Create("(user2)-[:FRIENDS]->(user1)")
                .ExecuteWithoutResults();
        }

        public void AddNewUser(string email, string password)
        {
            var new_user = new UserDTONeo4j
            {
                Email = email,
                Password = password
            };
            client.Cypher
                .Create("(user:UserDTONeo4j {newUser})")
                .WithParam("newUser", new_user)
                .ExecuteWithoutResults();
        }

        public void DeleteRelation(string email_1, string password_1, string email_2, string password_2)
        {
            client.Cypher
              .Match("(user1:UserDTONeo4j {email: {Email1}, password: {Password1}})-[r:FRIENDS]->(user2:UserDTONeo4j {email: {Email2}, password: {Password2}})")
              .WithParam("Email1", email_1)
              .WithParam("Password1", password_1)
              .WithParam("Email2", email_2)
              .WithParam("Password2", password_2)
              .Delete("r")
              .ExecuteWithoutResults();
            client.Cypher
              .Match("(user2:UserDTONeo4j {email: {Email2}, password: {Password2}})-[r:FRIENDS]->(user1:UserDTONeo4j {email: {Email1}, password: {Password1}})")              
              .WithParam("Email2", email_2)
              .WithParam("Password2", password_2)
              .WithParam("Email1", email_1)
              .WithParam("Password1", password_1)
              .Delete("r")
              .ExecuteWithoutResults();
        }

        public void DeleteUser(string email, string password)
        {
            client.Cypher
              .Match("(user:UserDTONeo4j {email: {Email}, password: {Password}})")
              .WithParam("Email", email)
              .WithParam("Password", password)
              .Delete("user")
              .ExecuteWithoutResults();
        }

        public List<UserDTONeo4j> GetAllUsers()
        {
            var users = client.Cypher
                  .Match("(user:UserDTONeo4j)")
                  .Return(user => user.As<UserDTONeo4j>())
                  .Results.ToList();
            return users;
        }

        public UserDTONeo4j GetUserByCredentials(string email, string password)
        {
            UserDTONeo4j ure = new UserDTONeo4j
            {
                Email = email,
                Password = password
            };
            var user_founded = client.Cypher
                  .Match("(user:UserDTONeo4j)")
                  .Where($"user.email ={email}")
                  .AndWhere($"user.password ={password}")
                  .Return(user => user.As<UserDTONeo4j>())
                  .Results.First();
            return user_founded;
        }

        public bool IsFriends(string email_1, string password_1, string email_2, string password_2)
        {
            var userFriends = client.Cypher
                  .Match("(user2:UserDTONeo4j {email: {Email2}, password: {Password2}})-[:FRIENDS]->(user1:UserDTONeo4j {email: {Email1}, password: {Password1}})")
                  .WithParam("Email1", email_1)
                  .WithParam("Password1", password_1)
                  .WithParam("Email2", email_2)
                  .WithParam("Password2", password_2)
                  .Return((user1) => new {
                      UserDTONeo4j = user1.As<UserDTONeo4j>()
                  })
                  .Results.ToList();
            if (userFriends.Count != 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public int PathToUser(string email_1, string password_1, string email_2, string password_2)
        {
            var path_to_user = client.Cypher
                  .Match("(user1:UserDTONeo4j {email: {Email1}, password: {Password1}})-[:FRIENDS]->(commonPeople)<-[:FRIENDS]-(user2:UserDTONeo4j {email: {Email2}, password: {Password2}})")
                  .WithParam("Email1", email_1)
                  .WithParam("Password1", password_1)
                  .WithParam("Email2", email_2)
                  .WithParam("Password2", password_2)
                  .Return(commonPeople => commonPeople.Count())
                  .Results.First();
            return (int)path_to_user;
        }

    }
}
