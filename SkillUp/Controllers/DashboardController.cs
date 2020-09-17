using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkillUp.Services;
using System.Security.Claims;

namespace SkillUp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ITaskRepository taskRepository;

        public DashboardController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }
        [Authorize]
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ViewModel = taskRepository.GetTasks(userId);
            return View(ViewModel);
        }
    }
}