using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.Groups
{
    public class IndexModel : PageModel
    {
        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public List<Group> Groups { get; set; }
        public void OnGet(int categoryId)
        {
            Groups = _productService.GetGroupsByCategoryId(categoryId);
            @ViewData["CategoryName"] = _productService.GetCategoryById(categoryId).CategoryName;
        }
        public IActionResult OnPost(string newGroup, int categoryId)
        {
          
            if (newGroup==null)
            {
                ModelState.AddModelError("", "لطفا نام را وارد کنید");
                Groups = _productService.GetGroupsByCategoryId(categoryId);
                return Page();
            }
            _productService.AddNewGroup(newGroup,categoryId);
            //Groups = _productService.GetGroupsByCategoryId(categoryId);
            return Redirect($"{categoryId}");
        }
    }
}
