using ECommerce.Application.DTOs.Order;

namespace ECommerce.Application.Services.Interfaces
{
    public interface IOrderManager
    {
        List<OrderGetDto> GetByProductIdWithDateRange(OrderGetRequestDto requestDto);
        void Add(OrderCreateDto orderCreateDto);
    }
}
