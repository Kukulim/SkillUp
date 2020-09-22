using SkillUp.Data;
using SkillUp.Models.ApplicationUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.Services.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        void IUserRepository.AddUser(ApplicationUser User)
        {
            dbContext.Users.Add(User);
            dbContext.SaveChanges();
        }

        void IUserRepository.DeleteTask(ApplicationUser User)
        {
            dbContext.Users.Remove(User);
            dbContext.SaveChanges();
        }

        void IUserRepository.EditUser(ApplicationUser User)
        {
            //dbContext.Entry(User).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var userEdit = dbContext.Users.Find(User.Id);
            if (userEdit != null)
            {
                userEdit.UserName = User.UserName;
                userEdit.FirstName = User.FirstName;
                userEdit.LastName = User.LastName;
                userEdit.PhoneNumber = User.PhoneNumber;
                userEdit.Email = User.Email;
                dbContext.SaveChanges();
            }
        }

        ApplicationUser IUserRepository.GetUser(string UserId)
        {
            return dbContext.Users.Where(x => x.Id == UserId).FirstOrDefault();
        }

        IEnumerable<ApplicationUser> IUserRepository.GetUsers()
        {
            return dbContext.Users;
        }
    }
}
