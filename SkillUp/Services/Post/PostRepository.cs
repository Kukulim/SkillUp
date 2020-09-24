using SkillUp.Data;
using SkillUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Services.Post
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext context;

        public PostRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void AddPost(PostsModel post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }

        public void DeletePost(PostsModel post)
        {
            context.Posts.Remove(post);
            context.SaveChanges();
        }

        public PostsModel GetPost(string UserId, int postId)
        {
            return context.Posts.Where(x => x.UserId == UserId).Where(t => t.Id == postId).FirstOrDefault();
        }

        public IEnumerable<PostsModel> GetPosts(string UserId)
        {
            return context.Posts.Where(x => x.UserId == UserId).ToList();
        }
    }
}
