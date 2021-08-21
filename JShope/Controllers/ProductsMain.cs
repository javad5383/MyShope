using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace JShope.Controllers
{



    public class ProductsMain : Controller
    {
        private IProductService _productService;
        private IQueryable<Product> _products;

        public ProductsMain(IProductService productService)
        {
            _productService = productService;
        }
        //selectedId: productId of selected item in search field suggestion(pass by JS)
        //search: search field value after user press search button
        //brands: checked brands in checkBox
        

        public IActionResult Index(int id, string show,string sortMethod,List<int> brands,string search,int selectedId)  
        {
            if (selectedId != 0)
            {
                var p = _productService.GetProductById(selectedId);
                //TODO: Redirect to single Product
            }
            if (search!=null)
            {
                _products = _productService.GetProductsByName(search);
                ViewData["search"] = search;
            }
            
            if (show != null)
            {

                switch (show)
                {
                    case "ByGroup":
                        ViewData["brand"] = _productService.GetDistinctBrandsByGroupId(id).ToList();
                        break;
                    case "BySubGroup":
                        ViewData["brand"] = _productService.GetDistinctBrandsBySubGroupId(id).ToList();
                        break;
                }

                 _products = _productService.ProductShowMethod(id, show);

            }
            if (!string.IsNullOrEmpty(sortMethod))
            {
                _products = _productService.SortProducts(_products, sortMethod);
                    
            }
            if (brands.Count!=0)
            {
                var selected = ( TempData["selectedBrands"]);
                _products = _productService.GetProductByBrand(_products, brands);
                    
               
            }
         
            TempData["selectedBrands"] = brands.ToList();
            ViewBag.sortMethod = sortMethod;
            ViewBag.curentShowMethod = show;
        
            if (_products!=null)
            {
                return View(_products.ToList());
            }
            return NotFound();





        }


        
        public IActionResult SearchBox(string search)
        {
            
            var result = _productService.GetProductsByName(search);
            
            return Json(result.Select(s=>new {value=s.ProductName, data = s.ProductId }).ToArray());
        }


        public IActionResult SingleProduct(int productId)
        {
            var product = _productService.GetProductById(productId);
            return View(product);
        }


    }
}
