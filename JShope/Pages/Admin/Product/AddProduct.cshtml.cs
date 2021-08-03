using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;

namespace JShope.Pages.Admin.Product
{
    public class AddProductModel : PageModel
    {
        private IProductService _productService;

        public AddProductModel(IProductService productService)
        {
            _productService = productService;
        }



        [BindProperty]
        public Models.Product Product { get; set; }



        public void OnGet()
        {

            var category = _productService.GetCategoryForFilterItems();
            ViewData["category"] = new SelectList(category, "Value", "Text");

            var groups = _productService.GetGroupsForFilterItems(int.Parse(category.First().Value));
            ViewData["groups"] = new SelectList(groups, "Value", "Text");

            var subGroups = _productService.GetSubGroupsForFilterItems(int.Parse(groups.First().Value));
            ViewData["subGroups"] = new SelectList(subGroups, "Value", "Text");


        }

        public IActionResult OnPost(List<IFormFile> file)
        {



            if (!ModelState.IsValid)
            {
                var category = _productService.GetCategoryForFilterItems();
                ViewData["category"] = new SelectList(category, "Value", "Text");

                var groups = _productService.GetGroupsForFilterItems(int.Parse(category.First().Value));
                ViewData["groups"] = new SelectList(groups, "Value", "Text");

                var subGroups = _productService.GetSubGroupsForFilterItems(int.Parse(groups.First().Value));
                ViewData["subGroups"] = new SelectList(subGroups, "Value", "Text");
                return Page();
            }

            var newProduct = new Models.Product()
            {
                ProductName = Product.ProductName,
                Color = Product.Color,
                Description = Product.Description,
                Price = Product.Price,
                Quantity = Product.Quantity,
                CategoryId = Product.CategoryId,
                GroupId = Product.GroupId,
                CreateDate = DateTime.Now

            };
            if (Product.SubGroupId != 0 )
            {
                newProduct.SubGroupId = Product.SubGroupId;
            }


            var pId = _productService.AddProduct(newProduct);

            if (file != null)
            {
                foreach (var item in file)
                {

                    var fileName = item.FileName;
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product", fileName);

                    using var stream = new FileStream(imagePath, FileMode.Create);

                    item.CopyTo(stream);
                    string imgName = Guid.NewGuid().ToString() + item.FileName;
                    _productService.AddProductImage(item.FileName, pId);
                }



            }



            return Redirect("/Admin/Product");
        }
    }
}
