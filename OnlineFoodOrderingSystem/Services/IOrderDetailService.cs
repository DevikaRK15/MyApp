using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Services
{
    public interface IOrderDetailService
    {
        Task<IEnumerable<OrderDetail>> GetAllAsync();

        Task<OrderDetail?> GetByIdAsync(int id);

        Task<OrderDetail> AddAsync(OrderDetailCreateDto dto);

        Task<bool> DeleteAsync(int id);
    }
}