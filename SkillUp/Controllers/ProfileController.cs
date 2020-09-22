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
using SkillUp.Services.User;

namespace SkillUp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserRepository userRepository;

        public ProfileController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = userRepository.GetUser(userId);
            return PartialView("_ProfileEdit" , user);
        }
        [HttpPost]
        public IActionResult EditProfile(ApplicationUser user)
        {
            userRepository.EditUser(user);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}