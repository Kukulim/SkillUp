using Microsoft.AspNetCore.Identity;
using SkillUp.Models.Person;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillUp.Models.ApplicationUser
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
        public string MentorId { get; set; }
        public List<TasksModel> Tasks { get; set; }
        public List<GoalsModel> Goals { get; set; }
        public List<FriendModel> Friends { get; set; }
        public List<PupilModel> Pupils { get; set; }
    }
}
