using JShope.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Cart()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
           var cart= _userService.GetUserCart(userId);
            return View(cart);
        }
        public IActionResult AddToCart(int productId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                if (productId!=0&&userId!=0)
                {
                    _userService.AddToCart(productId, userId);
                }
                
            }
            return RedirectToAction("cart");
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

        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProductBySubGroupId(id);
            return Json(product);
        }

        #endregion

    }
}
