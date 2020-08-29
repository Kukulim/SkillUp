﻿using Microsoft.AspNetCore.Identity;

namespace SkillUp.Models.ApplicationUser
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
    }
}
