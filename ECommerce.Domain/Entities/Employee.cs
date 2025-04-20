namespace ECommerce.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime BirthDate { get; set; }
        public string? Photo { get; set; }
        public string? Notes { get; set; }

        // navigation property
        public virtual List<Order> Orders { get; set; } = new();
    }
}
