using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Numerics;
using System.Security.Claims;
using System.Threading.Tasks;
using JShope.JShopeSecurity;
using JShope.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyEshop.Data;

namespace JShope.Services.Interface
{

    public class UserService : IUserService
    {
        private JShopeContext _context;

        public UserService(JShopeContext context)
        {
            _context = context;
        }
        public int AddUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;

        }

        public bool IsEmailExist(string email)
        {
            return _context.Users.Any(e => e.Email == email);
        }

        public Users Login(loginViewModel loginViewModel)
        {
            var HashPassword = PasswordHelper.EncodePasswordMd5(loginViewModel.Password);
            var user = _context.Users.SingleOrDefault(u => u.Email == loginViewModel.Email && u.Password == HashPassword);

            return user;
        }

        public bool ActiveUsers(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActivationCode == activeCode);
            if (user == null)
            {
                return false;
            }

            user.ActivationCode = Guid.NewGuid().ToString();
            user.IsActive = true;
            _context.Users.Update(user);
            _context.SaveChanges();


            return true;
        }

        public Users GetUserByUserId(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.UserId == userId);
        }

        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }

        public List<Users> GetUsersForPaging(int take = 8, int pageNumber = 1)
        {

            if (pageNumber == 0) pageNumber = 1;

            var skip = take * (pageNumber - 1);
            var userTake = _context.Users.OrderBy(u => u.Name).Skip(skip).Take(take).ToList();
            return userTake;
        }

        public void UpdateUser(Users user)
        {

            //_context.Update(user);
            _context.SaveChanges();
        }

        public EditProfileViewModel GetUserViewModel(int userId)
        {
            var cuser = _context.Users.FirstOrDefault(s => s.UserId == userId);
            var user = new EditProfileViewModel()
            {
                BankCardNumber = cuser.BankCardNumber,
                Email = cuser.Email,
                Family = cuser.Family,
                Name = cuser.Name,
                NationalCode = cuser.NationalCode,
                PhoneNumber = cuser.PhoneNumber,
                UserId = cuser.UserId,
                UserHomeAddress = cuser.UserHomeAddress
            };

            return user;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public string GetUserAvatarName(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.UserId == userId)?.UserAvatar;
        }

        public List<Users> SearchUsers(string keyWord)
        {
            return _context.Users.Where(u => u.Name.Contains(keyWord) || u.Family.Contains(keyWord)).ToList();
        }

        public void RemoveUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user!=null)
            {
                var deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", user.UserAvatar);

                if (File.Exists(deleteImagePath))
                {
                    File.Delete(deleteImagePath);
                }
                _context.Remove(user);
                _context.SaveChanges();
            }
           
        }

        public void RemoveUserAvatar(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user!=null)
            {
                var deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", user.UserAvatar);

                if (File.Exists(deleteImagePath))
                {
                    File.Delete(deleteImagePath);
                }

                user.UserAvatar = null;
                _context.SaveChanges();
            }
        }
    }
}
