using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Models
{
    public class CommentsModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public int PostId { get; set; }
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
