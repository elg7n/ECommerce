using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Interfaces
{
    public interface IOrderRepository
    {
        public List<Order> GetByProductIdWithDateRange(int productId, DateTime startDate, DateTime endDate);
    }
}
