using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PostDTO
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("postedby")]
        public ObjectId PostedBy { get; set; }

        [BsonElement("text")]
        public string Text { get; set; }
        
        [BsonElement("comments")]
        public List<CommentDTO> Comments { get; set; }

        [BsonElement("likes")]
        public List<LikeDTO> Likes { get; set; }

    }
}
