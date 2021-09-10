using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public bool IsFinish { get; set; }
        public bool IsSuccess { get; set; }
        public DateTime CreateDate { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public int Count { get; set; }
        public Users User { get; set; }
        public List<CartDetail> CartDetails { get; set; }
        public Orders Order  { get; set; }


    }
}
