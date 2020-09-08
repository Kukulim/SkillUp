using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Models
{
    public class MessagesModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string SenderId { get; set; }
        public string ReciverId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
