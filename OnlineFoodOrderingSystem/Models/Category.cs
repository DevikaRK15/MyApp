using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public ICollection<FoodItem>? FoodItems { get; set; }
    }
}
