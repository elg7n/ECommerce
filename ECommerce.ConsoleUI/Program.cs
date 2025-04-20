using ECommerce.Application.DTOs;
using ECommerce.Application.Services.Implementation;

namespace ECommerce.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var categoryManager = new CategoryManager();

            Console.WriteLine("Category adını daxil edin:");

            var categoryName = Console.ReadLine();

            Console.WriteLine("Category Description daxil edin:");

            var categoryDescription = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(categoryName) ||
               string.IsNullOrWhiteSpace(categoryDescription))
            {
                Console.WriteLine("Düzgün dəyər daxil edilmədi");

                return;
            }

            var categoryCreateDto = new CategoryCreateDto
            {
                Name = categoryName,
                Description = categoryDescription
            };

            categoryManager.Add(categoryCreateDto);

            var allCategories = categoryManager.GetAll();

            foreach (var item in allCategories)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }
    }
}
