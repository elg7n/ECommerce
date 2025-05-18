using ECommerce.Application.DTOs.Order;
using FluentValidation;

namespace ECommerce.Application.Validators.Order
{
    public class OrderGetRequestDtoValidator : AbstractValidator<OrderGetRequestDto>
    {
        public OrderGetRequestDtoValidator()
        {
            RuleFor(x => x.ProductId)
                .GreaterThan(0)
                .WithMessage("Id can not be negative");

            RuleFor(x => x.StartDate)
                .NotNull()
                .WithMessage("Start date can not be null");

            RuleFor(x => x.EndDate)
                .GreaterThanOrEqualTo(x=>x.StartDate)
                .WithMessage("End date must be greater or equal than start date")
                .NotNull()
                .WithMessage("End date can not be null");

            RuleFor(x => x.StartDate)
                .Must(x=>x.Date < DateTime.UtcNow)
                .WithMessage("Bugunun tarixinden boyuk ola bilmez")
                .NotNull()
                .WithMessage("Start date can not be null");
        }
    }
}
