using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
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

        public IActionResult OnPost(int id,IFormFile file)
        {
            var user = _userService.GetUserByUserId(id);
           
            user.UserId = Users.UserId;
            user.BankCardNumber = Users.BankCardNumber;
            user.Email = Users.Email;
            user.Family = Users.Family;
            user.Name = Users.Name;
            user.IsActive = Users.IsActive;
            user.NationalCode = Users.NationalCode;
            user.PhoneNumber = Users.PhoneNumber;
            user.UserHomeAddress = Users.UserHomeAddress;
            user.UserName = Users.UserName;





            if (file != null)
            {
                if (user.UserAvatar!=null)
                {
                    var deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", user.UserAvatar);

                    if (System.IO.File.Exists(deleteImagePath))
                    {
                        System.IO.File.Delete(deleteImagePath);
                    }
                }
                //delete previous avatar
               



                //change  avatar name in DB
                var newAvatarName = Guid.NewGuid() + "-" + file.FileName; 
                user.UserAvatar = newAvatarName;


                //save new avatar 
                var fileName = file.FileName;
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", newAvatarName);

                using var stream = new FileStream(imagePath, FileMode.Create);

                file.CopyTo(stream);

               

            }
            _userService.UpdateUser(user);
            return Redirect($"/admin/users/UserProfile/{id}");
        }

       
    }
}
