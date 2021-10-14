using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product
{
   
    public class DeleteModel : PageModel
    {
        private IProductService _productService;

        public DeleteModel(IProductService productService) 
        {
            _productService = productService;
        }
        [BindProperty] 
        public Models.Product Product { get; set; }
        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);
        }

        public IActionResult OnPost(int id)
        {
           
            var productImages = _productService.GetProductImage(id);
            if (productImages.Count!=0)
            {
                foreach (var item in productImages)
                {
                    string deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product/", item.Names);
                    if (System.IO.File.Exists(deleteImagePath))
                    {
                        System.IO.File.Delete(deleteImagePath);
                    }
                }
            }

            Product = _productService.GetProductById(id);
            _productService.RemoveProduct(Product);

            return Redirect("/admin/product");
        }
    }
}
