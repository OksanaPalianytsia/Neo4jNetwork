using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICommentDAL
    {
        CommentDTO GetCommentById(ObjectId id_comment);
        void AddNewComment(ObjectId user, string text);
        void DeleteComment(ObjectId id_comment);
        List<CommentDTO> GetAllComments();
        void UpsertComment(ObjectId id_comment, CommentDTO new_info_comment);
    }
}
