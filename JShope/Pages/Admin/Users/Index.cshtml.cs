using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Users
{
    
    public class IndexModel : PageModel
    {
        private IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public List<Models.Users> Users { get; set; }
        
        [BindProperty]
        public int NumberOfPages { get; set; }

        public void OnGet(int pageNumber,string search)
        {
            var take = 5;
            var userCount = _userService.GetUsers().Count;
            ViewData["userCount"] = userCount;



            NumberOfPages = userCount / take;


            if ((userCount % take) > 0)
            {
                NumberOfPages++;
            }


            if (search!=null)
            {
               Users= _userService.SearchUsers(search);
               

            }
            else
            {
               

                ViewData["pageId"] = pageNumber;


                Users = _userService.GetUsersForPaging(take, pageNumber);
            }
           
           

        }

     
    }
}
