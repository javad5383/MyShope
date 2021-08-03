using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;

namespace JShope.Controllers
{

  

    public class ProductsMain : Controller
    {
        private IProductService _productService;

        public ProductsMain(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {


            return View();
        }
       

        [Route("ShowByCategory/{categoryId}/{value?}")]
        public IActionResult ShowByCategory(int categoryId,string sortMethod)
        {
            
            var product = _productService.GetProductByCategoryId(categoryId);
            if (sortMethod != null)
            {
                product = _productService.SoreProducts(product, sortMethod);
            }
            ViewBag.sortMethod = sortMethod;
            return View("Index", product);
        }

        [Route("ShowByGroup/{groupId}")]
        public IActionResult ShowByGroup(int groupId, string sortMethod)
        {

            var product = _productService.GetProductByGroupId(groupId);
            if (sortMethod != null)
            {
                product = _productService.SoreProducts(product, sortMethod);

            }
            ViewBag.sortMethod = sortMethod;
            return View("Index", product);
        }

        [Route("ShowBySubGroup/{subGroupId}")]
        public IActionResult ShowBySubGroup(int subGroupId, string sortMethod)
        {

            var product = _productService.GetProductBySubGroupId(subGroupId);
            if (sortMethod != null)
            {
                product = _productService.SoreProducts(product, sortMethod);
               
            }
            ViewBag.sortMethod = sortMethod;
            return View("Index", product);
        }

      
       

    }
}
