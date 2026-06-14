using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Repositories
{
    public interface IOrderDetailRepository
    {
        Task<IEnumerable<OrderDetail>> GetAllAsync();

        Task<OrderDetail?> GetByIdAsync(int id);

        Task<OrderDetail> AddAsync(OrderDetail orderDetail);

        Task DeleteAsync(OrderDetail orderDetail);
    }
}