using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int FoodItemId { get; set; }
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public Order? Order { get; set; }

        public FoodItem? FoodItem { get; set; }
    }
}