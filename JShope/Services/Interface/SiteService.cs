using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Data;

namespace JShope.Services.Interface
{
    public class SiteService:ISiteService
    {
        private JShopeContext _context;

        public SiteService(JShopeContext context)
        {
            _context = context;
        }
        public int GetNumberOfNewOrders()
        {
            return _context.Orders.Count(s => !s.SeenByAdmin);
        }
    }
}
 