using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystem.Data;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly FoodOrderingDbContext _context;

        public OrderDetailRepository(FoodOrderingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllAsync()
        {
            return await _context.OrderDetails.ToListAsync();
        }

        public async Task<OrderDetail?> GetByIdAsync(int id)
        {
            return await _context.OrderDetails
                .FirstOrDefaultAsync(x => x.OrderDetailId == id);
        }

        public async Task<OrderDetail> AddAsync(OrderDetail orderDetail)
        {
            await _context.OrderDetails.AddAsync(orderDetail);
            await _context.SaveChangesAsync();

            return orderDetail;
        }

        public async Task DeleteAsync(OrderDetail orderDetail)
        {
            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();
        }
    }
}