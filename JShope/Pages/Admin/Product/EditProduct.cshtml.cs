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

namespace JShope.Pages.Admin.Product
{
    public class EditProductModel : PageModel
    {
        private IProductService _productService;

        public EditProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Models.Product Product { get; set; }
        [BindProperty] 
        public List<ProductImage> ProductImage { get; set; }

        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);
            ProductImage= _productService.GetProductImage(id);

        }

        public IActionResult OnPost(int id,List<int> imgIdForRemove,List<IFormFile> file)
        {

            if (imgIdForRemove!=null)
            {
                foreach (var item in imgIdForRemove)
                {
                    _productService.RemoveImage(item, id);
                }
               
               

            }

            if (Product!=null)
            {
               



                if (file != null)
                {

                    foreach (var item in file)
                    {

                        var fileName = Guid.NewGuid() + item.FileName;
                        var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product", fileName);

                        using var stream = new FileStream(imagePath, FileMode.Create);

                        item.CopyTo(stream);
                       
                        _productService.AddProductImage(fileName, id);
                    }


                }

                _productService.UpdateProduct(Product);

            }
            
           
           


           

                
            


            return Redirect("/admin/product");
        }
    }
}
