using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JShope.JShopeSecurity;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace JShope.Pages.Admin.Users
{
    
    public class AddUserModel : PageModel
    {
        private readonly IUserService _usereService;
       

        public AddUserModel(IUserService usereService)
        {
            _usereService = usereService;
           
        }
        [BindProperty] public Models.Users Users { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(IFormFile img)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (img != null)
            {

                var newAvatarName = Guid.NewGuid() + "-" + img.FileName;
                Users.UserAvatar = newAvatarName;

                //save image

                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", newAvatarName);

                using var stream = new FileStream(imagePath, FileMode.Create);

                img.CopyTo(stream);


            }
            Users.Password = PasswordHelper.EncodePasswordMd5(Users.Password);
            _usereService.AddUser(Users);
            return Redirect("/admin/users");
        }
    }
}
