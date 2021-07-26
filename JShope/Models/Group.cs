using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JShope.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public int CategoryId { get; set; }


        public List<SubGroup> SubGroups { get; set; }

        public Category Category { get; set; }

      
    }
}
