using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace JShope.Pages.Admin.Orders
{
    public class PostStatusModel : PageModel
    {

        private IUserService _userService;

        public PostStatusModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public Models.Orders Order { get; set; }
        public void OnGet(int orderId)
        {
            if (orderId!=0)
            {
                Order = _userService.GetOrderById(orderId);
                
            }
           
        }
        public IActionResult OnPost(string postalTrackingCode)
        {
            _userService.SaveOrderPostalTrackingCode(Order.OrderId, postalTrackingCode);
            return Redirect("/admin/orders/index");
        }
    }
}
