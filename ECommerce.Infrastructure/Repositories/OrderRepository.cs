using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public List<Order> GetByProductIdWithDateRange(int productId, DateTime startDate, DateTime endDate)
        {
            var orders = Table.Where(x => x.OrderDate >= startDate && x.OrderDate <= endDate)
                              .Where(x => x.OrderDetails.Any(x => x.ProductId == productId))
                              .Include(x=>x.OrderDetails)
                              .ToList();

            return orders;
        }
    }
}
