using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string CategoryName { get; set; }

        public string CategoryImageName { get; set; }


        public List<Group> Groups { get; set; }
    }
}
