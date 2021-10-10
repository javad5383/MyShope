using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Brands
{
    
    public class IndexModel : PageModel
    {
        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Models.Brands> Brands { get; set; }
        public List<Models.Product> Products { get; set; }

        public void OnGet(int brandId)
        {
           Brands= _productService.GetBrands();
           if (brandId!=0)
           {
               Products = _productService.GetProductByBrandId(brandId);
           }
        }

        public IActionResult OnPost(string brandName)
        {
            if (brandName!=null)
            {
                _productService.AddBrand(brandName);
            }

            return RedirectToPage();
        }
    }
}
