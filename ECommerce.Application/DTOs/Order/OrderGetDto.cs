using ECommerce.Domain.Entities;

namespace ECommerce.Application.DTOs.Order
{
    public class OrderGetDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public string? CustomerName { get; set; }

        public string? EmployeeFullName { get; set; }
    }
}
