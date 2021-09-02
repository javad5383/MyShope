using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class EditProfileViewModel
    {
        public int UserId { get; set; }


        public string Name { get; set; }

        [MaxLength(10)]
        [DataType(DataType.PostalCode)]

        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string NationalCode { get; set; }
        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserHomeAddress { get; set; }

        [Display(Name = "فامیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Family { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string PhoneNumber { get; set; }

        //public string UserAvatar { get; set; }

        [DataType(DataType.CreditCard)]
        public long BankCardNumber { get; set; }



    }
}
