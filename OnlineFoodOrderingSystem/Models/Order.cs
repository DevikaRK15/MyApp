using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}