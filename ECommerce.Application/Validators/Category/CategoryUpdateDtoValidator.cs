using ECommerce.Application.DTOs.Category;
using FluentValidation;

namespace ECommerce.Application.Validators.Category
{
    public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id can not be negative");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Name can not be null");

            RuleFor(x => x.Description)
                .NotNull()
                .WithMessage("Description can not be null");
        }
    }
}
