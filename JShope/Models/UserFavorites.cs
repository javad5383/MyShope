using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class UserFavorites
    {
        [Key]
        public int FavoritesId { get; set; }

        public int ProductId { get; set; }
        public int UserId { get; set; }
        
        public Users User { get; set; }
        public Product Products { get; set; }
    }
}
