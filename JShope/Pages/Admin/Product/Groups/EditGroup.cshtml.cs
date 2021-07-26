using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JShope.Pages.Admin.Product.Groups
{
    public class EditGroupModel : PageModel
    {
        private IProductService _productService;

        public EditGroupModel(IProductService productService)
        {
            _productService = productService;
        }


        [BindProperty]
        public Group Group { get; set; }
        public void OnGet(int groupId)
        {
            Group = _productService.GetGroupById(groupId);
            var category = _productService.GetCategoryForFilterItems();
            ViewData["category"] = new SelectList(category, "Value", "Text");
        }

        public IActionResult OnPost(int groupId)
        {

           
            _productService.EditGroup(groupId,Group.CategoryId,Group.GroupName);
            var categoryId = _productService.GetCategoryIdByGroupId(groupId);
            return Redirect($"/admin/product/groups/{categoryId}");

        }
    }
}
