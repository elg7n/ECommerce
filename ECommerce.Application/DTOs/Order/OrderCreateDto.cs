namespace ECommerce.Application.DTOs.Order
{
    public class OrderCreateDto
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
