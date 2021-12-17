using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILikeDAL
    {
        LikeDTO GetLikeById(ObjectId id_like);
        void AddNewLike(ObjectId user);
        void DeleteLike(ObjectId id_like);
        List<LikeDTO> GetAllLikes();
        void UpsertLike(ObjectId id_like, LikeDTO new_info_like);
    }
}
