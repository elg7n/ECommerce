using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Unit { get; set; }
        public decimal Price { get; set; }

        public int SupplierId {  get; set; }
        public virtual Supplier Supplier { get; set; } = default!;

        public int CategoryId {  get; set; }
        public virtual Category Category { get; set; } = default!;

        public virtual List<OrderDetail> OrderDetails { get; set; } = new();
    }
}
