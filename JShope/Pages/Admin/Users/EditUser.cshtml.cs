using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Users
{
   
    public class EditUserModel : PageModel
    {
        private IUserService _userService;

        public EditUserModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public Models.Users Users { get; set; }
        public void OnGet(int id)
        {
            Users = _userService.GetUserByUserId(id);
        }

        public IActionResult OnPost(int id, IFormFile file)
        {
            var userId = _userService.GetUserByUserId(id).UserId;
            var editProfileViewModel = new EditProfileViewModel()
            {
                BankCardNumber = Users.BankCardNumber,
                Email = Users.Email,
                Family = Users.Family,
                Name = Users.Name,
                NationalCode = Users.NationalCode,
                PhoneNumber = Users.PhoneNumber,
                UserHomeAddress = Users.UserHomeAddress
            };
            _userService.EditUser(editProfileViewModel,userId,file);
            return Redirect($"/admin/users/UserProfile/{id}");
        }


    }
}
