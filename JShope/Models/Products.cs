using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }





        [MaxLength(150)]
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string ProductName { get; set; }

        [Display(Name = "قیمت ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public decimal Price { get; set; }

        public int TotalQuantity { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }


        [Display(Name = "دسته بندی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public int CategoryId { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public int GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public int? BrandId { get; set; }
        public int Visits { get; set; }
        public DateTime CreateDate { get; set; }
      
        
        public List<ProductImage> ProductImages { get; set; }
        public SubGroup SubGroups { get; set; }
        public Group Group { get; set; }
        public List<ProductColors> ProductColors { get; set; }
        public Brands Brand { get; set; }
        public List<UserFavorites> UserFavorites { get; set; }
        public List<CartDetail> CartDetails { get; set; }
        public List<Specifications> Specifications { get; set; }
    }
}
