namespace ECommerce.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = default!;

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; } = default!;

        public virtual List<OrderDetail> OrderDetails { get; set; } = new();
    }
}
