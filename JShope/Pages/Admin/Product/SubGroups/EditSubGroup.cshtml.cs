using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JShope.Pages.Admin.Product.SubGroups
{
    public class EditSubGroupModel : PageModel
    {
        private IProductService _productService;

        public EditSubGroupModel(IProductService productService)
        {
            _productService = productService;
        }


        [BindProperty]
        public SubGroup SubGroup { get; set; }

        public void OnGet(int subGroupId)
        {
            SubGroup = _productService.GetSubGroupById(subGroupId);
            int groupId = _productService.GetSubGroupById(subGroupId).GroupId;
            int categoryId = _productService.GetCategoryIdByGroupId(groupId);
            var group = _productService.GetGroupsForFilterItems(categoryId);
            ViewData["group"] = new SelectList(group, "Value", "Text");
        }

        public IActionResult OnPost(int subGroupId)
        {
            if (SubGroup.SubGroupName!=null)
            {

               
                _productService.EditSubGroup(SubGroup.GroupId, subGroupId, SubGroup.SubGroupName);
                int groupId = _productService.GetSubGroupById(subGroupId).GroupId;
                return Redirect(($"/admin/product/subgroups/{groupId}"));
            }

            return Page();
        }
    }
}
