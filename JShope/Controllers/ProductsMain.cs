﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;

namespace JShope.Controllers
{



    public class ProductsMain : Controller
    {
        private IProductService _productService;

        public ProductsMain(IProductService productService)
        {
            _productService = productService;
        }

       
        public IActionResult Index(int id, string show,string sortMethod)
        {
            if (show!=null)
            {
                var product = _productService.ProductShowMethod(id, show);
                if (!string.IsNullOrEmpty(sortMethod))
                {
                    product = _productService.SortProducts(product, sortMethod);
                    
                }

                ViewBag.sortMethod = sortMethod;
                ViewBag.curentShowMethod = show;
                return View(product.ToList());
            }

            
            return View();
        }


     
       
       



    }
}
