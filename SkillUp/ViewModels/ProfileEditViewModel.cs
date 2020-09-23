using Microsoft.AspNetCore.Mvc.Rendering;
using SkillUp.Models.ApplicationUser;
using SkillUp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillUp.ViewModels
{
    public class ProfileEditViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }

        public List<SelectListItem> LanguageTypes { get; set; } = new List<SelectListItem>();
        public ProfileEditViewModel()
        {
            foreach (var item in Enum.GetValues(typeof(LanguageEnum)))
            {
                LanguageTypes.Add(new SelectListItem
                {
                    Value = ((int)item).ToString(),
                    Text = item.ToString()
                });
            }

        }
    }
}
