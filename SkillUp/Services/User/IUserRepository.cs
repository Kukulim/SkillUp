using SkillUp.Models.ApplicationUser;
using System.Collections.Generic;

namespace SkillUp.Services.User
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();

        ApplicationUser GetUser(string UserId);

        void AddUser(ApplicationUser User);

        void EditUser(ApplicationUser User);

        void DeleteTask(ApplicationUser User);
    }
}