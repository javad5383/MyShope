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
        public string NationalCode { get; set; }

        public string UserHomeAddress { get; set; }


        public string Family { get; set; }

        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        //public string UserAvatar { get; set; }

        [DataType(DataType.CreditCard)]
        public long BankCardNumber { get; set; }



    }
}
