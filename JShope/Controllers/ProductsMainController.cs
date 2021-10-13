using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace JShope.Controllers
{
    public class ProductsMainController : Controller
    {
        private IProductService _productService;
        private IEnumerable<Product> _products;
        public ProductsMainController(IProductService productService)
        {
            _productService = productService;
        }
        //selectedId: productId of selected item in search field suggestion(pass by JS)
        //search: search field value after user press search button
        //brands: checked brands in checkBox
        //showBy:a string passed when user press one of sorting tag on view to specify what is current show method. (ByCategory or ByGroups or BySubGroups) 
        //sortMethod:a string passed from view for sort products
        public IActionResult Index(int categoryId,string showBy, int groupId, int subGroupId, string sortMethod, List<int> brands, string search, int selectedId)
        {
            if (selectedId != 0)
            {
                return Redirect($"/productSMain/SingleProduct?productId={selectedId}");
            }

            #region Show Method
            if (categoryId != 0||showBy=="ByCategory")
            {
                if (categoryId==0) categoryId = (int)TempData["id"];
                _products = _productService.GetProductByCategoryId(categoryId);
                @ViewBag.curentShowMethod = "ByCategory";
                TempData["id"] = categoryId;
            }
            if (groupId != 0 || showBy=="ByGroups")
            {
                if (groupId == 0) groupId = (int)TempData["id"];
                _products = _productService.GetProductByGroupId(groupId);
                @ViewBag.curentShowMethod = "ByGroups";
                TempData["id"] = groupId;
            }
            if (subGroupId != 0 || showBy == "BySubGroups")
            {
                if (subGroupId == 0) subGroupId = (int)TempData["id"];
                _products = _productService.GetProductBySubGroupId(subGroupId);
                @ViewBag.curentShowMethod = "BySubGroups";
                TempData["id"] = subGroupId;
            }
            #endregion
            
            if (search != null)
            {
                _products = _products.Where(n => n.ProductName.Contains(search));
                ViewData["search"] = search;
            }
           
            if (!string.IsNullOrEmpty(sortMethod))
            {
                
                _products = _productService.SortProducts(_products, sortMethod);

            }
          
            if (brands.Count != 0)
            {

                //var selected = TempData["selectedBrands"];
                _products = _products.Where(b => b.BrandId != null && brands.Contains((int)b.BrandId));
            }

            TempData["selectedBrands"] = brands.ToList();
            ViewBag.sortMethod = sortMethod;
            //ViewBag.curentShowMethod = show;

            if (_products != null)
            {
                return View(_products.ToList());
            }
            return NotFound();

        }

        //Return products for AutoComplete(search box)
        public IActionResult SearchBox(string search)
        {

            var result = _productService.GetProductsByName(search);

            return Json(result.Select(s => new { value = s.ProductName, data = s.ProductId }).ToArray());
        }
        public IActionResult SingleProduct(int productId)
        {
            var product = _productService.GetProductById(productId);
            return View(product);
        }

        public IActionResult AddFavorite(int id)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            ViewBag.userId = userId;
            _productService.AddFavorite(id, userId);
            return Json(Ok());
        }

    }
}
