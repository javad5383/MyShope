﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public  class ProductImage
    {
        [Key]
        public  int ImageId { get; set; }

        public  string Names { get; set; }

        public  int ProductId { get; set; }


        
        public  Product Product { get; set; }
    }
}
