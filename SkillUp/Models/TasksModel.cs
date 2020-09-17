using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Models
{
    public class TasksModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Completed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }
    }
}
