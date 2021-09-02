using JShope.JShopeSecurity;
using JShope.Models;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public void UpdateUser(EditProfileViewModel user,int userId)
        {
            var usr = GetUserByUserId(userId);
            usr.Email = user.Email;
            usr.BankCardNumber = user.BankCardNumber;
            usr.Family = user.Family;
            usr.Name = user.Name;
            usr.NationalCode = user.NationalCode;
            usr.PhoneNumber = user.PhoneNumber;
            usr.UserHomeAddress = user.UserHomeAddress;
            usr.IsComplete = true;

            _context.SaveChanges();
        }
        public void UpdateUser(Users user)
        {
         

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
            if (user != null)
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
            if (user != null)
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

        public void AddToCart(int productId, int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            var cart = _context.Carts.FirstOrDefault(c => c.UserId == user.UserId && !c.IsFinish);
            if (product != null)
            {
                if (cart == null)
                {
                    Cart crt = new Cart()
                    {
                        UserId = user.UserId,
                        CreateDate = DateTime.Now,
                        IsFinish = false,
                        IsSuccess = false
                    };
                    _context.Carts.Add(crt);
                    _context.SaveChanges();
                    CartDetail cartDetail = new CartDetail()
                    {
                        ProductId = product.ProductId,
                        CartId = crt.CartId,
                        Price = product.Price,
                        Quantity = 1
                    };
                    crt.TotalPrice = cartDetail.Price;
                    crt.Count = cartDetail.Quantity;
                    _context.CartDetails.Add(cartDetail);
                    _context.SaveChanges();

                }
                else
                {
                    var cartDetail = _context.CartDetails.FirstOrDefault(c => c.CartId == cart.CartId && c.ProductId == product.ProductId);
                    if (cartDetail == null)
                    {
                        CartDetail crtDetail = new CartDetail()
                        {
                            ProductId = product.ProductId,
                            CartId = cart.CartId,
                            Price = product.Price,
                            Quantity = 1
                        };
                        _context.CartDetails.Add(crtDetail);

                    }
                    else
                    {
                        cartDetail.Quantity++;
                        cartDetail.Price = cartDetail.Quantity * product.Price;

                    }
                    _context.SaveChanges();
                    //calculate total price and count
                    var cartDetailTotalPrice = _context.CartDetails.Where(c => c.CartId == cart.CartId).Select(p => p.Price).Sum();
                    var cartDetailTotalCount = _context.CartDetails.Where(c => c.CartId == cart.CartId).Select(p => p.Quantity).Sum();
                    cart.TotalPrice = cartDetailTotalPrice;
                    cart.Count = cartDetailTotalCount;
                    _context.SaveChanges();
                }
            }







        }

      

        public Cart GetUserCart(int userId)
        {
            return _context.Carts
                .Include(u=>u.User)
                .Include(d => d.CartDetails)
                .ThenInclude(p => p.Product)
                .ThenInclude(i => i.ProductImages)
                .FirstOrDefault(c => c.UserId == userId && !c.IsFinish);
        }

        public List<CartDetail> GetCartDetailForGhostUser(List<int> productId)
        {
            var product = new List<Product>();
            var cartDetail = new List<CartDetail>();

            foreach (var item in productId)
            {
                var p = _context.Products
                    .Include(p=>p.ProductImages)
                    .FirstOrDefault(a => a.ProductId == item);
                product.Add(p);

            }

            foreach (var item in product)
            {
                //var a = product.Count(d => d.ProductId == item.ProductId);
                var crtDetail = cartDetail.FirstOrDefault(p => p.ProductId == item.ProductId);
                if (crtDetail==null)
                {
                    var c = new CartDetail()
                    {
                        ProductId = item.ProductId,
                        Price = item.Price,
                        Quantity = 1,
                        Product = item,
                        

                    };

                    cartDetail.Add(c);
                }
                else
                {
                    crtDetail.Quantity += 1;
                    crtDetail.Price = item.Price* crtDetail.Quantity;
                }

                
            }

            return  cartDetail;

        }

        public Tuple<bool, bool> CheckUserValidation(int userId)
        {
            var isComplete = _context.Users.FirstOrDefault(u => u.UserId == userId).IsComplete;
            var isActive = _context.Users.FirstOrDefault(u => u.UserId == userId).IsActive;
            return new Tuple<bool, bool>(isComplete, isActive);
        }

        public void DeleteFromCart(int cartId, int cartDetailId, int userId)
    {
        var cart = _context.Carts.FirstOrDefault(c => c.UserId == userId && c.CartId == cartId);
        var crtDetail = _context.CartDetails.FirstOrDefault(c => c.CartId == cart.CartId && c.DetailId == cartDetailId);


        if (crtDetail != null)
        {
            _context.CartDetails.Remove(crtDetail);
            _context.SaveChanges();
            //calculate total price and count
            var cartDetailTotalPrice = _context.CartDetails.Where(c => c.CartId == cart.CartId).Select(p => p.Price).Sum();
            var cartDetailTotalCount = _context.CartDetails.Where(c => c.CartId == cart.CartId).Select(p => p.Quantity).Sum();
            cart.TotalPrice = cartDetailTotalPrice;
            cart.Count = cartDetailTotalCount;
            _context.SaveChanges();

        }

    }
}
}
