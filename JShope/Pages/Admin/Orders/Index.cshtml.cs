using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Orders
{
    public class IndexModel : PageModel
    {
        private IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public List<Models.Orders> Orders { get; set; }
        public void OnGet()
        {
           Orders= _userService.GetAllOrders();
        }
    }
}
