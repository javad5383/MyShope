using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.SubGroups
{
   
    public  class IndexModel : PageModel
    {
        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public List<SubGroup> SubGroups { get; set; }

        [BindProperty]
        public List<Models.Product>  Product { get; set; }
        public void OnGet(int groupId)
        {
            
            
                SubGroups = _productService.GetSubGroupsByGroupId(groupId);
                ViewData["GroupName"] = _productService.GetGroupById(groupId).GroupName;
                ViewData["CategoryId"] = _productService.GetGroupById(groupId).CategoryId;
             



        }

        public IActionResult OnPost(int groupId, string subGroupName)
        {



            if (subGroupName==null||groupId==0)
            {
                return Redirect($"/admin/product/subgroups/{groupId}");
            }

            _productService.AddSubGroups(groupId,subGroupName);
            return Redirect($"/admin/product/subgroups/{groupId}");
           

        }
    }
}
