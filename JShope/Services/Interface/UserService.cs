using JShope.JShopeSecurity;
using JShope.Models;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Query;

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
            var user = _context.Users.SingleOrDefault(u => u.Email == loginViewModel.Email ||u.PhoneNumber==loginViewModel.Email && u.Password == HashPassword);

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

        public void EditUser(EditProfileViewModel user, int userId, IFormFile userAvatar)
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
            if (userAvatar != null)
            {
                if (usr.UserAvatar != null)
                {
                    var deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", usr.UserAvatar);
                    if (System.IO.File.Exists(deleteImagePath))
                    {
                        System.IO.File.Delete(deleteImagePath);
                    }
                }
                //delete previous avatar
                //change  avatar name in DB
                var newAvatarName = Guid.NewGuid() + "-" + userAvatar.FileName;
                usr.UserAvatar = newAvatarName;
                //save new avatar 
                var fileName = userAvatar.FileName;
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", newAvatarName);

                using var stream = new FileStream(imagePath, FileMode.Create);

                userAvatar.CopyTo(stream);
                _context.SaveChanges();
            }
        }
        public void UpdateUser(Users user)
        {


            _context.SaveChanges();
        }

        public EditProfileViewModel GetUserViewModel(int userId)
        {
            var cUser = _context.Users.FirstOrDefault(s => s.UserId == userId);
            if (cUser!=null)
            {
                var user = new EditProfileViewModel()
                {
                    BankCardNumber = cUser.BankCardNumber,
                    Email = cUser.Email,
                    Family = cUser.Family,
                    Name = cUser.Name,
                    NationalCode = cUser.NationalCode,
                    PhoneNumber = cUser.PhoneNumber,
                    UserId = cUser.UserId,
                    UserHomeAddress = cUser.UserHomeAddress,
                    UserAvatar = cUser.UserAvatar
                };
                return user;
            }

            return null;

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

        public void AddToCart(int productId, int userId, int selectedProductColor)
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
                        IsSuccess = false,
                        DeliveryAddress = user.UserHomeAddress
                        
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
                    if (selectedProductColor != 0) { cartDetail.SelectedProductColor = selectedProductColor; }
                    crt.TotalPrice = cartDetail.Price;
                    crt.Count = cartDetail.Quantity;
                    _context.CartDetails.Add(cartDetail);
                    _context.SaveChanges();

                }
                else
                {

                    var cartDetail = selectedProductColor != 0 ?
                        _context.CartDetails.FirstOrDefault(c => c.CartId == cart.CartId && c.ProductId == product.ProductId && c.SelectedProductColor == selectedProductColor)
                        : _context.CartDetails.FirstOrDefault(c => c.CartId == cart.CartId && c.ProductId == product.ProductId);
                    if (cartDetail == null)
                    {
                        CartDetail crtDetail = new CartDetail()
                        {
                            ProductId = product.ProductId,
                            CartId = cart.CartId,
                            Price = product.Price,
                            Quantity = 1,
                            SelectedProductColor = selectedProductColor
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

        public List<CartDetail> AddToCartForGuestUser(List<CartDetail> cartDetails, int productId, int selectedProductColorId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product!=null)
            {
                if (cartDetails != null )
                {
                    var existingCartDetail = cartDetails.Find(p => p.ProductId == productId && p.SelectedProductColor == selectedProductColorId);
                    if (existingCartDetail != null)
                    {

                        existingCartDetail.Quantity++;
                        existingCartDetail.Price = product.Price * existingCartDetail.Quantity;
                        existingCartDetail.SelectedProductColor = selectedProductColorId;
                        
                    }
                    else
                    {
                       
                        CartDetail crtDetail = new CartDetail()
                        {
                            Product = product,
                            ProductId = product.ProductId,
                            Price = product.Price,
                            Quantity = 1,
                            SelectedProductColor = selectedProductColorId
                        };
                       
                        cartDetails.Add(crtDetail);
                        return cartDetails;

                    }
                    
                }
                else
                {
                    var cartDetailList = new List<CartDetail>();
                    CartDetail crtDetail = new CartDetail()
                    {
                        Product = product,
                        ProductId = product.ProductId,
                        Price = product.Price,
                        Quantity = 1,
                        SelectedProductColor = selectedProductColorId
                    };

                    cartDetailList.Add(crtDetail);
                    return cartDetailList;

                }
               

            }

            return null;

        }

        public CartDetail GetCartDetailForGuestUser(int productId, int selectedProductColorId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                var productColor = _context.ProductColors.FirstOrDefault(p =>
                    p.ProductId == product.ProductId && p.ColorId == selectedProductColorId);
                CartDetail cartDetail = new CartDetail()
                {
                    Product = product,
                    ProductId = product.ProductId,
                    Price = product.Price,
                    Quantity = 1,
                    SelectedProductColor = productColor?.ProductId ?? 0 //if productColor!=null{SelectedProductColor== productColor.ProductId else:=0}
                };
                return cartDetail;
            }

            return null;
        }

        public Cart GetUserCart(int userId)
        {
            return _context.Carts
                .Include(u => u.User)
                .Include(d => d.CartDetails)
                .ThenInclude(p => p.Product)
                .ThenInclude(i => i.ProductImages)
                .FirstOrDefault(c => c.UserId == userId && !c.IsFinish);
        }

        public Tuple<bool, bool> CheckUserValidation(int userId)
        {
            var isComplete = _context.Users.FirstOrDefault(u => u.UserId == userId).IsComplete;
            var isActive = _context.Users.FirstOrDefault(u => u.UserId == userId).IsActive;
            return new Tuple<bool, bool>(isComplete, isActive);
        }

        public Cart GetCartByCartId(int cartId)
        {
            return _context.Carts
                .Include(u => u.User)
                .Include(d => d.CartDetails)
                .ThenInclude(p => p.Product)
                .ThenInclude(i => i.ProductImages)
                .FirstOrDefault(c => c.CartId == cartId);
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

        public void AddNewOrder(Cart cart, string authority)
        {
            authority = authority.TrimStart(new char[] { '0' });//Remove  Leading Zeros
            Orders order = new Orders()
            {
                UserId = cart.UserId,
                CartId = cart.CartId,
                DeliveryAddress = cart.DeliveryAddress,
                CreatedDate = DateTime.Now,
                PaymentAuthority = authority,
                OrderNumber = $"JK-{cart.UserId}-{cart.CartId}-{cart.CreateDate.Year}-{cart.CreateDate.Month}-{cart.CreateDate.Day}-{cart.CreateDate.Hour}-{cart.CreateDate.Minute}-{cart.CreateDate.Second}-{cart.CreateDate.Millisecond}"

            };
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public IQueryable<Orders> GetAllOrders()
        {
            return _context.Orders.Select(a => a)
                .Include(c => c.Cart.User)
                .Include(d => d.Cart)
                .ThenInclude(d => d.CartDetails);


        }

        public Orders GetOrderById(int orderId)
        {
           
            return _context.Orders
                .Include(c => c.Cart)
                .ThenInclude(u => u.User)
                .Include(cd => cd.Cart.CartDetails)
                .ThenInclude(p => p.Product)
                .ThenInclude(i=> i.ProductColors)
                .Include(cd => cd.Cart.CartDetails)
                .ThenInclude(p => p.Product)
                .ThenInclude(i => i.ProductImages)
                .FirstOrDefault(o => o.OrderId == orderId);
        }

        public void SaveOrderPostalTrackingCode(int orderId, string postalTrackingCode)
        {
            var order = _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                order.PostalTrackingCode = postalTrackingCode;
                order.IsDelivered = true;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Orders> SortOrders(IEnumerable<Orders> orders, string sortingMethod)
        {
            switch (sortingMethod)
            {
                case "ByName":
                    return orders.OrderBy(c => c.Cart.User.Name);
                case "ByOrderNumber":
                    return orders.OrderBy(n => n.OrderNumber);
                case "ByQuantity":

                    return orders.OrderByDescending(c => c.Cart.CartDetails.Sum(q => q.Quantity));
                case "ByDate":
                    return orders.OrderByDescending(c => c.CreatedDate);
                case "ByPayment":
                    return orders.OrderByDescending(p => p.Cart.IsSuccess).ThenByDescending(d => d.CreatedDate);
                case "ByDeliverStatus":
                    return orders.OrderBy(i => i.IsDelivered).ThenByDescending(p => p.Cart.IsSuccess);

                default:
                    return orders.OrderBy(i => i.IsDelivered).ThenByDescending(p => p.Cart.IsSuccess); ;


            }
        }

        public IEnumerable<Orders> SearchOrders(string searchStr, IEnumerable<Orders> orders)
        {
            return orders.Where(s => s.Cart.User.Name.Contains(searchStr) || s.OrderNumber.Contains(searchStr));
        }

        public void SeenByAdmin()
        {
            var seen = _context.Orders.Where(s => !s.SeenByAdmin);
            foreach (var item in seen)
            {
                item.SeenByAdmin = true;
            }
            _context.SaveChanges();

        }


    }
}
