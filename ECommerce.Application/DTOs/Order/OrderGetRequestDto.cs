namespace ECommerce.Application.DTOs.Order
{
    public class OrderGetRequestDto
    {
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
