using AutoMapper;
using ECommerce.Application.AutoMapping;
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.DTOs.Order;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Application.Validators.Category;
using ECommerce.Application.Validators.Order;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Repositories;

namespace ECommerce.Application.Services.Implementation
{
    public class OrderManager : IOrderManager
    {
        private readonly OrderRepository _orderRespository;
        private readonly OrderDetailRepository _orderDetailRespository;
        private readonly IMapper _mapper;
        public OrderManager()
        {
            _orderRespository = new OrderRepository();

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();

            });

            _mapper = config.CreateMapper();
        }

        public void Add(OrderCreateDto orderCreateDto)
        {
            var order = _mapper.Map<Order>(orderCreateDto);

            var addedOrder = _orderRespository.Add(order);

            var orderDetail = new OrderDetail
            {
                OrderId = addedOrder.Id,
                ProductId = orderCreateDto.ProductId,
                Quantity = orderCreateDto.Quantity
            };

            _orderDetailRespository.Add(orderDetail);
        }

        public List<OrderGetDto> GetByProductIdWithDateRange(OrderGetRequestDto requestDto)
        {
            var orderGetRequestDtoValidator = new OrderGetRequestDtoValidator();

            var validationResult = orderGetRequestDtoValidator.Validate(requestDto);

            if (validationResult.IsValid == false)
                throw new Exception(validationResult.Errors.First().ErrorMessage);

            var orders = _orderRespository.GetByProductIdWithDateRange(requestDto.ProductId, requestDto.StartDate, requestDto.EndDate);

            var orderResponse = _mapper.Map<List<OrderGetDto>>(orders);

            return orderResponse;
        }
    }
}
