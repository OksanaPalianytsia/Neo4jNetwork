using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LikeDTO
    {
        [BsonElement("user")]
        public ObjectId User { get; set; }
        public LikeDTO(ObjectId user)
        {
            User = user;
        }
    }
}
