using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Services.Interfaces
{
    public interface ICategoryManager
    {
        void Add(CategoryCreateDto categoryCreateDto);
        List<CategoryAllDto> GetAll();
        Category? GetById(int categoryId);
    }
}
