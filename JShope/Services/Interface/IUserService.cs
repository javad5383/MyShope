using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

using JShope.Models;
using Microsoft.AspNetCore.Http;

namespace JShope.Services.Interface
{
   public interface IUserService
   {
       int AddUser(Users user);

       bool IsEmailExist(string email);

       Users Login(loginViewModel loginViewModel);

       bool ActiveUsers(string activeCode);

       Users GetUserByUserId(int userId);
       List<Users> GetUsers();
       List<Users> GetUsersForPaging(int take=8,int pageNumber=1);

        void EditUser(EditProfileViewModel user,int userId,IFormFile userAvatar);
        void UpdateUser(Users user);

        EditProfileViewModel GetUserViewModel(int userId);

        void SaveChanges();

        string GetUserAvatarName(int userId);
       List<Users>  SearchUsers(string keyWord);

       void RemoveUser(int userId);
       void RemoveUserAvatar(int userId);
        //cart
       void AddToCart(int productId,int userId,int selectedProductColor);
       List<CartDetail> AddToCartForGuestUser(List<CartDetail> cartDetails,int productId, int selectedProductColorId);
       CartDetail GetCartDetailForGuestUser(int productId,int selectedProductColorId);
       void DeleteFromCart(int cartId,int cartDetailId,int userId);
       Cart GetUserCart(int userId);

      Tuple<bool, bool> CheckUserValidation(int userId);

      Cart GetCartByCartId(int cartId);

      void AddNewOrder(Cart cart,string authority);

      IQueryable<Orders> GetAllOrders();
      Orders GetOrderById(int orderId);

      void SaveOrderPostalTrackingCode(int orderId, string postalTrackingCode);
      IEnumerable<Orders> SortOrders(IEnumerable<Orders> orders, string sortingMethod);

      IEnumerable<Orders> SearchOrders(string searchStr, IEnumerable<Orders> orders);
      void SeenByAdmin();

   }
}
