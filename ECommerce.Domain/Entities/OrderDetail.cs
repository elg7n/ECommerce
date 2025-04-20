namespace ECommerce.Domain.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; } = default!;

        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = default!;
    }
}
