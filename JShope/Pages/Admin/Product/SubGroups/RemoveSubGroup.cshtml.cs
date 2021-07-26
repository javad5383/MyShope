using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.SubGroups
{
    public class RemoveSubGroupModel : PageModel
    {
        private IProductService _productService;

        public RemoveSubGroupModel(IProductService productService)
        {
            _productService = productService;
        }

     
        public SubGroup SubGroup { get; set; }

        public void OnGet(int subGroupId)
        {
            SubGroup = _productService.GetSubGroupById(subGroupId);
        }

        public IActionResult OnPost(int subGroupId)
        {
            var sub = _productService.GetSubGroupById(subGroupId);
            if (sub != null)
            {
               _productService.RemoveSubGroup(sub);
               return Redirect($"/admin/product/subgroups/{sub.GroupId}");
            }

            return NotFound();
        }
    }
}
