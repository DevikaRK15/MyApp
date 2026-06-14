namespace OnlineFoodOrderingSystem.DTOs
{
    public class OrderDetailCreateDto
    {
        public int OrderId { get; set; }

        public int FoodItemId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}