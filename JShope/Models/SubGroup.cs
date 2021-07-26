using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class SubGroup
    {
        [Key]
        public int SubGroupId { get; set; }


        public string SubGroupName { get; set; }

        public int GroupId { get; set; }

       

        
        public Group Group { get; set; }

        public List<Product> Products { get; set; }
    }
}
