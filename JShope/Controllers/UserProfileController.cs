using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using System.Security.Claims;
using JShope.Models;

namespace JShope.Controllers
{
    public class UserProfileController : Controller
    {
        private IUserService _userService;

        public UserProfileController(IUserService userService)
        {
            _userService = userService;
        }

      
        public IActionResult Profile()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = _userService.GetUserByUserId(userId);

            return View(user);
        }





        public IActionResult EditProfile()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = _userService.GetUserViewModel(userId);
            return View(user);
        }



        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel users)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = _userService.GetUserByUserId(userId);


            user.Email = users.Email;
            user.BankCardNumber = users.BankCardNumber;
            user.Family = users.Family;
            user.Name = users.Name;
            user.NationalCode = users.NationalCode;
            user.PhoneNumber = users.PhoneNumber;


            _userService.SaveChanges();
            return View();
        }
    }
}
