using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class ProductColors
    {

        [Key]
        public int ColorId { get; set; }

        [Display(Name = "نام رنگ")]
       
        public string ColorName { get; set; }

        [Display(Name = "تعداد")]
       
        public int Quantity { get; set; }
        [Display(Name = "رنگ")]
        
        public string ColorCode { get; set; }

        public int ProductId { get; set; }
        
        public Product Product { get; set; }

    }
}
