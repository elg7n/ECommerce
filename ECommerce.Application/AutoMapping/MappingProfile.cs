using AutoMapper;
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.DTOs.Order;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryUpdateDto, Category>()
                .ReverseMap();

            CreateMap<Order, OrderGetDto>()
                .ForMember(x=>x.CustomerName, y=>y.MapFrom(x => x.Customer.Name))
                .ForMember(x=>x.EmployeeFullName, y=>y.MapFrom(x => x.Employee.FirstName + " " + x.Employee.LastName));
        }
    }
}
