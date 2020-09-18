using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkillUp.Services;

namespace SkillUp.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskRepository taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }
        public IActionResult LoadTasks()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ViewModel = taskRepository.GetTasks(userId);
            return PartialView("_Tasks", ViewModel);
        }
        public IActionResult LoadSingleTask(int taskId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ViewModel = taskRepository.GetTask(userId, taskId);
            return PartialView("_TasksDetailsPopup", ViewModel);
        }
    }
}