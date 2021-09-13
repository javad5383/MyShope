﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Hanssens.Net;
using ZarinPal;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
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
                //Response.Cookies.Append("CartLength", cart.CartDetails.Select(q=>q.Quantity).Sum().ToString());ToDo
                return View(cart);
            }

            var cartCookie = Request.Cookies["Cart"];

            if (cartCookie != null)
            {
                var cartCookieString = cartCookie.Split(",");
                var intProductId = Array.ConvertAll(cartCookieString, int.Parse).ToList();
                ViewData["cart"] = _userService.GetCartDetailForGuestUser(intProductId);
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
            else
            {
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
                return PartialView("_GateWayError",e);
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
                    _userService.AddNewOrder(cart,authority);

                }   
             
            }
            else
            {
                cart.IsFinish = true;
                cart.IsSuccess = false;
                _userService.SaveChanges();
                ViewBag.isSuccess = false;
                _userService.AddNewOrder(cart,"");

            }
            ViewBag.authority = HttpContext.Request.Query["Authority"];
            return View(cart);

        }

      
    }


}



