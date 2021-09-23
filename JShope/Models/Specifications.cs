using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    //Product Specifications
    public class Specifications
    {
        [Key]
        public int SpecificationId { get; set; }
        public string HeadLine { get; set; }
        public int ProductId { get; set; }
        public List<Titles> Titles { get; set; }
        public Product Product { get; set; }
    }
}
