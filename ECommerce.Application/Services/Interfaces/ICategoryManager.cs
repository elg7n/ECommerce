using ECommerce.Application.DTOs.Category;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Services.Interfaces
{
    public interface ICategoryManager
    {
        void Add(CategoryCreateDto categoryCreateDto);
        List<CategoryAllDto> GetAll();
        Category? GetById(int categoryId);

        void Update(CategoryUpdateDto categoryUpdateDto);
        void Delete(int id);
    }
}
