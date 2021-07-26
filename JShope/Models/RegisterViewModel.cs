using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class RegisterViewModel
    {
         [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر")]
        public string Email { get; set; }

        [Display(Name = "رمزعبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

         [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Compare("Password" ,ErrorMessage = "لطفا {0} را وارد کنید")]
         [DataType(DataType.Password)]
        public string RePassword { get; set; }


    }
}
