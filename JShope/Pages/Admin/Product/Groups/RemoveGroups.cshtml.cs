using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JShope.Pages.Admin.Product.Groups
{
    [Authorize(Policy = "Admin")]
    public class RemoveGroupsModel : PageModel
    {
        private IProductService _productService;

        public RemoveGroupsModel(IProductService productService)
        {
            _productService = productService;
        }

        public Models.Group Group { get; set; }
        public void OnGet(int id)
        {
            Group = _productService.GetGroupById(id);
        }
        public IActionResult OnPost(int id)
        {
            var subGroups = _productService.GetSubGroupsByGroupId(id);
            if (id!=0)
            {
                var categoryId = _productService.GetCategoryIdByGroupId(id);
                _productService.RemoveGroupById(id);
               
                return Redirect($"/admin/product/groups/{categoryId}");
            }

            return Page();
        }
    }
}
