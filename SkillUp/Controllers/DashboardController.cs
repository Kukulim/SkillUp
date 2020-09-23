using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkillUp.Services;
using System.Security.Claims;

namespace SkillUp.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoadPosts()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ViewModel = taskRepository.GetTasks(userId);
            return PartialView("_Tasks", ViewModel);
        }
    }
}