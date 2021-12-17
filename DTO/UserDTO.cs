using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("firstname")]
        public string FirstName { get; set; }

        [BsonElement("lastname")]
        public string LastName { get; set; }

        [BsonElement("interests")]
        public List<string> Interests { get; set; }

        [BsonElement("subscribers")]
        public List<UserDTO> Subscribers { get; set; }

        [BsonElement("friends")]
        public List<UserDTO> Friends { get; set; }

        [BsonElement("posts")]
        public List<PostDTO> Posts { get; set; }

    }
}
