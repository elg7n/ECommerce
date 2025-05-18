using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Application.DTOs.Category;
using FluentValidation;

namespace ECommerce.Application.Validators.Category
{
    public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
    {

        public CategoryCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Name can not be null");

            RuleFor(x=>x.Description)
                .NotNull()
                .WithMessage("Description can not be null");
        }
    }
}
