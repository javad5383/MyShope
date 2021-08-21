using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string UserName { get; set; }

       
        public string Name { get; set; }

        public bool IsAdmin { get; set; }
        public string NationalCode { get; set; }

        public string UserHomeAddress { get; set; }
        public string Family { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Email { get; set; }


        [Required(ErrorMessage = "لطفا{0} را وارد کنید ")]
        public string Password { get; set; }

        public  string UserIp { get; set; }
        public bool IsActive { get; set; }

        public string PhoneNumber { get; set; }

        public string UserAvatar { get; set; }

        public string ActivationCode { get; set; }

        public bool IsDelete { get; set; }

        public long BankCardNumber { get; set; }

        public List<Cart> Carts { get; set; }

        

        //public string IpAddress { get; set; }
    }
}
