using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkillUp.Models;
using SkillUp.Models.ApplicationUser;
using SkillUp.Models.Person;

namespace SkillUp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TasksModel> Tasks { get; set; }
        public DbSet<GoalsModel> Goals { get; set; }
        public DbSet<CommentsModel> Comments { get; set; }
        public DbSet<MessagesModel> Messages { get; set; }
        public DbSet<PostsModel> Posts { get; set; }
        public DbSet<FriendModel> Friends { get; set; }
        public DbSet<PupilModel> Pupils { get; set; }
    }
}
