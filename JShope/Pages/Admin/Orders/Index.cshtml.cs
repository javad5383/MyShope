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

        public IEnumerable<Models.Orders> Orders { get; set; }
        public void OnGet(string sortingMethod,string search)
        {
           
            Orders = _userService.GetAllOrders();
            if (sortingMethod==null&& search==null)
            {
               
                Orders = _userService.SortOrders(Orders, "ByDeliverStatus");
            }
            if (sortingMethod != null)
            {
                ViewData["sort"] = sortingMethod;
               Orders = _userService.SortOrders(Orders, sortingMethod);
            }
            _userService.SeenByAdmin();
            if (search == null) return;
            ViewData["search"] = search;
            Orders = _userService.SearchOrders(search, Orders);


        }
    }
}
