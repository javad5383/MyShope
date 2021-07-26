using System.Collections.Generic;
using System.Linq;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.Categories
{
    public class AddCategoryModel : PageModel
    {
        private IProductService _productService;

        public AddCategoryModel(IProductService productService)
        {
            _productService = productService;
        }


        [BindProperty]
        public List<Category> Categories { get; set; }


       


        public void OnGet( )
        
        {
           
          

           
            Categories = _productService.GetCategory().ToList();
        }
      
        public IActionResult OnPost( string newCategoryName)
        {

            if (newCategoryName != null)
            {
                _productService.AddCategory(newCategoryName);
                return Redirect("categories");
            }
            return Page();
        }
    }
}
