using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.SubGroups
{
    public class ProductsOfSubModel : PageModel
    {
        private IProductService _productService;

        public ProductsOfSubModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Models.Product> Product { get; set; }
        public ProductImage ProductImage { get; set; }
        public void OnGet(int subGroupId)
        {
            Product = _productService.GetProductBySubGroupId(subGroupId);
            
        }
    }
}
