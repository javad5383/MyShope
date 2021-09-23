using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    //Product Specifications Titles
    public class Titles
    {
        [Key]
        public int TitleId { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public int SpecificationId { get; set; }
        
        public Specifications Specification { get; set; }
    }
}
