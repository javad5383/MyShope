using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing.Matching;
using Newtonsoft.Json;

namespace JShope.Pages.Admin.Product
{
    public class IndexModel : PageModel
    {
        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public List<Models.Product> Product { get; set; }

        public  int CategoryId { get; set; }
        public  int GroupId { get; set; }
        public  int SubGroupId { get; set; }
      
     
        public void  OnGet(int subGroupId)
        {
           
            Product = _productService.GetProduct();

           
        }
      

        public IActionResult OnPost(string search,int catId,int groupId,int subGroupId)
        {
            if (search!=null)
            {
                Product = _productService.SearchProducts(search);
                
                return Page();
            }
           
            
            //filter :

            //filter Categories
            if (catId != 0)
            {

              

                CategoryId = catId;
                //filter Groups
                if (groupId!=0)
                {
                    Product = _productService.FilterProduct(catId , groupId);
                    GroupId = groupId;

                    if (subGroupId!=0)
                    {
                        Product = _productService.FilterProduct(catId, groupId , subGroupId);
                        SubGroupId = subGroupId;
                    }
                    return Page();
                }


                Product = _productService.FilterProduct(catId);
                return Page();
            }

           
            
            if (Product==null)
            {
                return NotFound();

            }
            Product = _productService.GetProduct();

            return Page();
        }
    }
}
