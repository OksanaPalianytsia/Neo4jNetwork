using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPostDAL
    {
        List<PostDTO> SortPostsByInsertData();
        void AddLikeToPost(ObjectId id_post, ObjectId user);
        void DeleteLikeToPost(ObjectId id_post, ObjectId user);
        void AddCommentToPost(ObjectId id_post, ObjectId user, string text);
        void DeleteCommentToPost(ObjectId id_post, ObjectId user, string text);
        PostDTO GetPostById(ObjectId id_post);
        void AddNewPost(PostDTO post);
        void DeletePost(ObjectId id_post);
        List<PostDTO> GetAllPosts();
        List<PostDTO> GetPostsOfCertainUser(ObjectId user_posts);
        void UpsertPost(ObjectId id_post, PostDTO new_info_post);
    }
}
