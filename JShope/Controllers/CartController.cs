using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

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
                //Response.Cookies.Append("CartLength", cart.CartDetails.Select(q=>q.Quantity).Sum().ToString());ToDo
                return View(cart);
            }
            var cartCookie = Request.Cookies["Cart"];
            if (cartCookie != null)
            {
                var cartDetailList=JsonConvert.DeserializeObject<List<CartDetail>>(cartCookie);
                ViewData["cart"] = cartDetailList;
            }
            return View();
        }
        public IActionResult AddToCart(string productId, string selectedColor)
        {
            var proId = int.Parse(productId);
            var selectedProductColorId = 0;
            if (selectedColor != null)
            {
                selectedProductColorId = int.Parse(selectedColor);
            }

            if (User.Identity.IsAuthenticated)
            {
                // Add to cart for logged in users
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (proId != 0 && userId != 0)
                {
                    _userService.AddToCart(proId, userId, selectedProductColorId);
                }
            }
            else
            {
                //Add to cartDetail to cookies for not logged in user's
                var cartCookie = Request.Cookies["Cart"];
                CookieOptions option = new CookieOptions { Expires = DateTime.Now.AddDays(5), Secure = true };
                if (cartCookie != null)
                {
                    var cartDetailList = JsonConvert.DeserializeObject<List<CartDetail>>(cartCookie);
                    var addToCart = _userService.AddToCartForGuestUser(cartDetailList, proId, selectedProductColorId);
                    var jsonCartDetail = JsonConvert.SerializeObject(cartDetailList);
                    Response.Cookies.Append("Cart", jsonCartDetail, option);
                }
                else
                {
                    var addToCart = _userService.AddToCartForGuestUser(null, proId, selectedProductColorId);
                    var jsonCartDetail = JsonConvert.SerializeObject(addToCart);
                    Response.Cookies.Append("Cart", jsonCartDetail, option);
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int cartId, int cartDetailId, int productId)
        {
            //DeleteFrom Cart For  Logged In Users
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
                if (cartCookie != null && productId != 0)
                {
                    var cartItemIds = cartCookie.Split(",").ToList();

                    if (cartItemIds.Count <= 1)
                    {
                        Response.Cookies.Delete("Cart");
                    }
                    else
                    {
                        //DeleteFrom Cart For Not Logged In Users
                        cartItemIds.RemoveAll(i => i == productId.ToString());
                        if (cartItemIds.Count == 0)
                        {
                            Response.Cookies.Delete("Cart");
                        }

                        var newList = string.Join(",", cartItemIds);
                        Response.Cookies.Append("Cart", newList, option);
                    }

                }



            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Shopping()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var cart = _userService.GetUserCart(userId);

            return View(cart);
        }

        [Authorize]
        public IActionResult ShoppingPayment()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var validation = _userService.CheckUserValidation(userId);

            if (!validation.Item1 || !validation.Item2) //if both Item1 & Item2 Is true, GoTo Payment (Item1:User profile is Complete or not? && Item2:is User active? )
            {
                return PartialView("_CheckUserValidation", validation);
            }

            var cart = _userService.GetUserCart(userId);
            return View(cart);
        }

        public IActionResult PaymentRequest()
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var cart = _userService.GetUserCart(userId);

                var payment = new ZarinpalSandbox.Payment((int)cart.TotalPrice);

                var res = payment.PaymentRequest("خرید اینترنتی", "https://localhost:44328/cart/Verification/" + cart.CartId, "javad.mohammadi5383@gmail.com", "09139824915");

                if (res.Result.Status == 100)
                {
                    return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
                }
            }
            catch (Exception e)
            {
                return PartialView("_GateWayError", e);
            }


            return NotFound();
        }

        public IActionResult Verification(int id)
        {
            var cart = _userService.GetCartByCartId(id);
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];
                var payment = new ZarinpalSandbox.Payment((int)cart.TotalPrice);
                var res = payment.Verification(authority).Result;

                if (res.Status == 100)
                {
                    cart.IsFinish = true;
                    cart.IsSuccess = true;
                    ViewBag.isSuccess = true;
                    _userService.SaveChanges();
                    _userService.AddNewOrder(cart, authority);

                }

            }
            else
            {
                cart.IsFinish = true;
                cart.IsSuccess = false;
                _userService.SaveChanges();
                ViewBag.isSuccess = false;
                _userService.AddNewOrder(cart, "");

            }
            ViewBag.authority = HttpContext.Request.Query["Authority"];
            return View(cart);

        }

    }


}



