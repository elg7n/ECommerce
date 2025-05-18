namespace ECommerce.Application.DTOs.Category
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
