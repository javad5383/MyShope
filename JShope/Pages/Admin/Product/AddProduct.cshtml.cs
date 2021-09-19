﻿using System;
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

        public ProductColors ProductColor { get; set; }
        //[BindProperty]
        //public List<ProductColors> ProductColorList{ get; set; }

        public void OnGet()
        {
            #region Select

            var category = _productService.GetCategoryForFilterItems();
            ViewData["category"] = new SelectList(category, "Value", "Text");

            var groups = _productService.GetGroupsForFilterItems(int.Parse(category.First().Value));
            ViewData["groups"] = new SelectList(groups, "Value", "Text");

            var subGroups = _productService.GetSubGroupsForFilterItems(int.Parse(groups.First().Value));
            ViewData["subGroups"] = new SelectList(subGroups, "Value", "Text");

            #endregion

        }

        public IActionResult OnPost(List<IFormFile> file, List<int> quantity, List<string> colorName, List<string> colorCode)
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
                Description = Product.Description,
                Price = Product.Price,
                TotalQuantity  = Product.TotalQuantity,
                CategoryId = Product.CategoryId,
                GroupId = Product.GroupId,
                CreateDate = DateTime.Now

            };
            if (Product.SubGroupId != 0)
            {
                newProduct.SubGroupId = Product.SubGroupId;
            }
            var pId = _productService.AddProduct(newProduct);
            if (quantity != null && colorName != null)
            {
                
                var colorsList = new List<ProductColors>();
                for (int i = 0; i < quantity.Count; i++)
                {
                    var colors = new ProductColors
                    {
                        Quantity = quantity[i],
                        ColorCode = colorCode[i],
                        ColorName = colorName[i],
                        ProductId = pId
                    };
                    colorsList.Add(colors);
                }
                _productService.AddColors(colorsList);
            }
            
            if (file != null)
            {
                foreach (var item in file)
                {
                    var fileName = item.FileName;
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product", fileName);

                    using var stream = new FileStream(imagePath, FileMode.Create);

                    item.CopyTo(stream);
                    string imgName = Guid.NewGuid() + item.FileName;
                    _productService.AddProductImage(item.FileName, pId);
                }
            }
            return Redirect("/Admin/Product");
        }
    }
}
