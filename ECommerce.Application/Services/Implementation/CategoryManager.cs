using AutoMapper;
using ECommerce.Application.AutoMapping;
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Application.Validators.Category;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Repositories;

namespace ECommerce.Application.Services.Implementation
{
    public class CategoryManager : ICategoryManager
    {
        private readonly CategoryRespository _categoryRespository;
        private readonly IMapper _mapper;
        public CategoryManager()
        {
            _categoryRespository = new CategoryRespository();

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();

            });

            _mapper = config.CreateMapper();
        }

        public void Add(CategoryCreateDto categoryCreateDto)
        {
            var categoryValidator = new CategoryCreateDtoValidator();

            var validationResult = categoryValidator.Validate(categoryCreateDto);

            if (validationResult.IsValid == false)
                throw new Exception(validationResult.Errors.First().ErrorMessage);

            var category = new Category
            {
                Name = categoryCreateDto.Name,
                Description = categoryCreateDto.Description
            };

            _categoryRespository.Add(category);
        }

        public void Update(CategoryUpdateDto categoryUpdateDto)
        {
            var categoryValidator = new CategoryUpdateDtoValidator();

            var validationResult = categoryValidator.Validate(categoryUpdateDto);

            if (validationResult.IsValid == false)
                throw new Exception(validationResult.Errors.First().ErrorMessage);

            var category = _categoryRespository.GetById(categoryUpdateDto.Id);

            if (category == null)
                throw new Exception("Category not found");

            var updatedCategory = _mapper.Map<Category>(category);

            _categoryRespository.Update(updatedCategory);
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

        public void Delete(int id)
        {
            var category = _categoryRespository.GetById(id);

            if (category == null)
                throw new Exception("Category not found");

            _categoryRespository.Delete(id);
        }
    }
}
