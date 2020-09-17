using SkillUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Services
{
    public interface ITaskRepository
    {
        IEnumerable<TasksModel> GetTasks(string UserId);
        TasksModel GetTask(string UserId, int taskId);
        void AddTask(string UserId, TasksModel task);
        void DeleteTask(TasksModel task);
    }
}
