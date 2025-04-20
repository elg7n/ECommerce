﻿namespace ECommerce.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        //navigation property
        public virtual List<Product> Products { get; set; } = new();
    }
}
