using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SkillUp.Data;
using SkillUp.Models.ApplicationUser;

namespace SkillUp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ProfileController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult EditProfile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = dbContext.Users.Where(x => x.Id == userId).FirstOrDefault();
            return PartialView("_ProfileEdit" , user);
        }
    }
}