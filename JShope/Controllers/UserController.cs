using JShope.JShopeSecurity;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace JShope.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return null;
        }

        #region Login

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(loginViewModel usr)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _userService.Login(usr);
           
            if (user==null)
            {
                ModelState.AddModelError("Email", "گاربر با مشخصات وارد شده یافت نشد");
                return View();
            }
            
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim("IsAdmin", user.IsAdmin.ToString())
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties
            {
                IsPersistent = usr.RememberMe
            };
           
            
            await HttpContext.SignInAsync(principal, properties);
            return Redirect("/");
        }

        #endregion

        #region Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (_userService.IsEmailExist(register.Email))
            {
                ModelState.AddModelError("Email", "ایمیل تکراری");
                return View();
            }

            var user = new Users()
            {
                Email = register.Email,
                ActivationCode = Guid.NewGuid().ToString(),
                IsDelete = false,
                UserName = register.Email,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                UserAvatar = "default.jpeg"

            };
            _userService.AddUser(user);

            return RedirectToAction("Welcome");
        }


        [Authorize]
        #endregion
        [Route("/Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [Authorize]
        public IActionResult Welcome()
        {
            return View();
        }

        [Authorize]
        [Route("/activation/{activeCode}")]
        public IActionResult Activation(string activeCode)
        {
            bool activation = _userService.ActiveUsers(activeCode);

            if (activation)
            {
                return View("Welcome");
            }

            return NotFound();

        }
    }
}
