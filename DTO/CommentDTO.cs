using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommentDTO
    {

        [BsonElement("user")]
        public ObjectId User { get; set; }

        [BsonElement("text")]
        public string Text { get; set; }

        public CommentDTO(ObjectId user, string text)
        {
            User = user;
            Text = text;
        }
    }
}
