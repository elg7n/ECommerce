using ECommerce.Application.DTOs;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Repositories;

namespace ECommerce.Application.Services.Implementation
{
    public class CategoryManager : ICategoryManager
    {
        private readonly CategoryRespository _categoryRespository;
        public CategoryManager()
        {
            _categoryRespository = new CategoryRespository();
        }

        public void Add(CategoryCreateDto categoryCreateDto)
        {
            if (string.IsNullOrWhiteSpace(categoryCreateDto.Name) ||
                string.IsNullOrWhiteSpace(categoryCreateDto.Description))
                return;

            var category = new Category
            {
                Name = categoryCreateDto.Name,
                Description = categoryCreateDto.Description
            };

            _categoryRespository.Add(category);
        }

        public List<CategoryAllDto> GetAll()
        {
            var categories = _categoryRespository.GetAll();

            if(categories == null)
                return new List<CategoryAllDto>();

            var categoriesAllDto = new List<CategoryAllDto>();

            foreach (var category in categories)
            {
                categoriesAllDto.Add(new CategoryAllDto
                {
                    Id = category.Id,
                    Name = category.Name
                });
            }

            return categoriesAllDto;
        }

        public Category? GetById(int categoryId)
        {
            var category = _categoryRespository.GetById(categoryId);

            return category;
        }
    }
}
