namespace OnlineFoodOrderingSystem.DTOs
{
    public class FoodItemCreateDto
    {
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}