using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.Categories
{
    [Authorize(Policy = "Admin")]
    public class RemoveCategoryModel : PageModel
    {
        private IProductService _productService;

        public RemoveCategoryModel(IProductService productService)
        {
            _productService = productService;
        }

        
        public Models.Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _productService.GetCategoryById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (id!=0)
            {
                var group = _productService.GetGroupsByCategoryId(id);

                var subGroup = _productService.GetSubGroupsByCategoryId(id);
                _productService.RemoveCategoryById(id);

                return Redirect("/admin/product/categories/addCategory");
            }

            return Page();
        }
    }
}
