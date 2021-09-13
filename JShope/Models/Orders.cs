using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int CartId { get; set; }
        public int UserId { get; set; }
        public string DeliveryAddress { get; set; }
        public string PostalTrackingCode { get; set; }
        public string PaymentAuthority { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool SeenByAdmin { get; set; }//just for notifications

        public Cart Cart { get; set; }

    }
}
