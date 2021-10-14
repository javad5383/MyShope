using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace JShope.Pages.Admin.Users
{
  
    public class RemoveUserModel : PageModel
    {
        private IUserService _userService;

        public RemoveUserModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public Models.Users Users { get; set; }
        public void OnGet(int userId)
        {
            Users = _userService.GetUserByUserId(userId);
        }

        public IActionResult OnPost(int userId)
        {
           
            _userService.RemoveUser(userId);
            return Redirect("/admin/users");
        }
    }
}
