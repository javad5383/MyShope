using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Brands
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        public string BrandName { get; set; }


        public List<Product> Products { get; set; }

        public List<Group> Groups { get; set; }
    }
}
