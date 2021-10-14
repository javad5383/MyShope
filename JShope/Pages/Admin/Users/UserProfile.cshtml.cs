using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Users
{
    
    public class UserProfileModel : PageModel
    {
        private IUserService _userService;

        public UserProfileModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public Models.Users Users { get; set; }
        public void OnGet(int id)
        {
            Users = _userService.GetUserByUserId(id);
        }
    }
}
