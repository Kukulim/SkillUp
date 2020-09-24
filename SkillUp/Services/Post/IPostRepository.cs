using SkillUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Services.Post
{
    public interface IPostRepository
    {
        IEnumerable<PostsModel> GetPosts(string UserId);
        PostsModel GetPost(string UserId, int postId);
        void AddPost(PostsModel post);
        void DeletePost(PostsModel post);
    }
}
