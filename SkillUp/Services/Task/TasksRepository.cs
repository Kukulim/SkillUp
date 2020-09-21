using SkillUp.Data;
using SkillUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Services
{
    public class TasksRepository :ITaskRepository
    {
        private readonly ApplicationDbContext context;

        public TasksRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddTask(string UserId, TasksModel task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(TasksModel task)
        {
            throw new NotImplementedException();
        }

        public TasksModel GetTask(string UserId, int taskId)
        {
            return context.Tasks.Where(x => x.UserId == UserId).Where(t=>t.Id == taskId).FirstOrDefault();
        }

        public IEnumerable<TasksModel> GetTasks(string UserId)
        {
            return context.Tasks.Where(t => t.UserId == UserId).ToList();
        }
    }
}
