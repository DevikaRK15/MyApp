using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllAsync();

        Task<Order?> GetByIdAsync(int id);

        Task<Order> AddAsync(OrderCreateDto dto);

        Task<bool> DeleteAsync(int id);
    }
}