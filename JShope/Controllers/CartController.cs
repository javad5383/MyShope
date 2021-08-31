using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Hanssens.Net;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Http;

namespace JShope.Controllers
{
    public class CartController : Controller
    {
        private IUserService _userService;

        public CartController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var cart = _userService.GetUserCart(userId);
                return View(cart);
            }

            var cartCookie = Request.Cookies["Cart"];

            if (cartCookie != null)
            {
                var cartCookieString = cartCookie.Split(",");
                var intProductId = Array.ConvertAll(cartCookieString, int.Parse).ToList();
                ViewData["cart"] = _userService.GetCartDetailForGhostUser(intProductId);
            }
            return View();
        }
        public IActionResult AddToCart(int productId)
        {
            if (User.Identity.IsAuthenticated)
            {
                //Add to cart for logged in users
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (productId != 0 && userId != 0)
                {
                    _userService.AddToCart(productId, userId);
                }

            }
            //Add to cart for not logged in user's
            CookieOptions option = new CookieOptions { Expires = DateTime.Now.AddDays(5), Secure = true };
            var cartCookie = Request.Cookies["Cart"];
            if (cartCookie != null)
            {
                var newCookie = cartCookie + "," + productId;
                Response.Cookies.Append("Cart", newCookie, option);

            }
            else
            {
                Response.Cookies.Append("Cart", productId.ToString(), option);
            }
            return RedirectToAction("Index");




        }

        public IActionResult Delete(int cartId, int cartDetailId, int productId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (userId != 0)
                {
                    _userService.DeleteFromCart(cartId, cartDetailId, userId);
                }
            }
            else
            {
                CookieOptions option = new CookieOptions { Expires = DateTime.Now.AddDays(5), Secure = true };
                var cartCookie = Request.Cookies["Cart"];
                if (cartCookie!=null&&productId!=0)
                {
                    var cartItemIds = cartCookie.Split(",").ToList();
                    
                    if (cartItemIds.Count <= 1)
                    {
                        Response.Cookies.Delete("Cart");
                    }
                    else
                    {
                        cartItemIds.RemoveAll(i => i == productId.ToString());
                        if (cartItemIds.Count==0)
                        {
                            Response.Cookies.Delete("Cart");
                        }
                       
                        var newList = string.Join(",", cartItemIds);
                        Response.Cookies.Append("Cart", newList,option);
                    }
                   
                }
              
               

            }

            return RedirectToAction("Index");
        }
    }
}
