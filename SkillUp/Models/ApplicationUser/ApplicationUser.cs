using Microsoft.AspNetCore.Identity;
using SkillUp.Models.Person;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillUp.Models.ApplicationUser
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [ScaffoldColumn(false)]
        public string MentorId { get; set; }
        public List<TasksModel> Tasks { get; set; }
        public List<GoalsModel> Goals { get; set; }
        public List<FriendModel> Friends { get; set; }
        public List<PupilModel> Pupils { get; set; }
    }
}
