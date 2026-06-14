using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }

        [Required]
        public string FoodName { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}