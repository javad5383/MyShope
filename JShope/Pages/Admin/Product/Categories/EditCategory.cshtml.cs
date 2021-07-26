using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JShope.Pages.Admin.Product.Categories
{
    public class EditCategoryModel : PageModel
    {
        private IProductService _productService;

        public EditCategoryModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _productService.GetCategoryById(id);
        }

        public IActionResult OnPost(int categoryId,string newCategoryName)
        {
            if (newCategoryName==null)
            {
                ModelState.AddModelError("","لطفا نام جدید را وارد کنید");

                return Page();
            }

            _productService.EditCategory(categoryId,newCategoryName);
             return Redirect("/admin/product/Categories/addcategory");
        }
    }
}
