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

        public string ColorName { get; set; }

        public int Quantity { get; set; }
        
        public string ColorCode { get; set; }

        public int ProductId { get; set; }
        
        public Product Product { get; set; }

    }
}
