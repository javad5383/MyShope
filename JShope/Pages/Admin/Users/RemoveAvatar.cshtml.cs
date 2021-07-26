using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Users
{
    public class RemoveAvatarModel : PageModel
    {


        private IUserService _userService;

        public RemoveAvatarModel(IUserService userService)
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
            _userService.RemoveUserAvatar(userId);
            return Redirect($"/admin/users/editUser/{userId}");
        }
    }
}
