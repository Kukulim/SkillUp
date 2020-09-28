using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkillUp.Models;
using SkillUp.Services;
using SkillUp.Services.Post;
using System.Security.Claims;

namespace SkillUp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IPostRepository postRepository;

        public DashboardController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadPosts()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ViewModel = postRepository.GetPosts(userId);
            return PartialView("_PostList", ViewModel);
        }
        [HttpGet]
        public IActionResult NewPost()
        {
            return PartialView("_NewPost");
        }
        [HttpPost]
        public IActionResult NewPost(PostsModel postsModel)
        {
            postRepository.AddPost(postsModel);
            return RedirectToAction("Index");
        }

    }
}