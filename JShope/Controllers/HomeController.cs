using System;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JShope.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _productService;
        private IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IUserService userService)
        {
            _logger = logger;
            _productService = productService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            //add to cart from cookies(If user Added Items to Cart before login)
            if (User.Identity.IsAuthenticated)
            {

                var cartCookie = Request.Cookies["Cart"];
                if (cartCookie != null)
                {
                    var cartDetails = JsonConvert.DeserializeObject<List<CartDetail>>(cartCookie);
                    //var itemIds = cartDetails.Select(p => p.Product.ProductId);
                    //var cartCookieString = cartCookie.Split(",");
                    //var intProductIds = Array.ConvertAll(cartCookieString, int.Parse).ToList();
                    var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    foreach (var item in cartDetails)
                    {
                        _userService.AddToCart(item.ProductId, userId, item.SelectedProductColor);
                    }
                    Response.Cookies.Delete("Cart");
                    Response.Cookies.Append("CartLength", cartDetails.Count.ToString());
                    return Redirect("/cart");
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region ReturnJson

        public IActionResult GetGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_productService.GetGroupsForFilterItems(id));
            return Json(new SelectList(list, "Value", "Text"));
        }
        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_productService.GetSubGroupsForFilterItems(id));
            return Json(new SelectList(list, "Value", "Text"));
        }
        public IActionResult GetBrands(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_productService.GetBrandSelectListItems(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        //public IActionResult GetProductByBrands(int brandId)
        //{
        //    var products = _productService.GetProductByBrandId(brandId);

           

        //   return Json( products);

        //}
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProductBySubGroupId(id);
            return Json(product);
        }

        #endregion

    }

}
