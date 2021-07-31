using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using JShope.Services.Interface;

namespace JShope.Controllers
{

    public enum mamal
    {
        mamad,
        khar,
        shotor,
        sag
    }


    public class ProductsMain : Controller
    {
        private IProductService _productService;

        public ProductsMain(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(Enum inp)
        {


            return View();
        }

        [Route("ShowByCategory/{categoryId}")]
        public IActionResult ShowByCategory(int categoryId)
        {

            var product = _productService.GetProductByCategoryId(categoryId);
            return View("Index", product);
        }

        [Route("ShowByGroup/{groupId}")]
        public IActionResult ShowByGroup(int groupId)
        {

            var product = _productService.GetProductByGroupId(groupId);
            return View("Index", product);
        }

        [Route("ShowBySubGroup/{subGroupId}")]
        public IActionResult ShowBySubGroup(int subGroupId)
        {

            var product = _productService.GetProductBySubGroupId(subGroupId);
            return View("Index", product);
        }

       

    }
}
