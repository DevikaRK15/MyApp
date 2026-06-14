using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Data
{
    public class FoodOrderingDbContext : DbContext
    {
        public FoodOrderingDbContext(
            DbContextOptions<FoodOrderingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<FoodItem> FoodItems { get; set; }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}