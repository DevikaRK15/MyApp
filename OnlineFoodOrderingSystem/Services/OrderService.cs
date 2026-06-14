using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;
using OnlineFoodOrderingSystem.Repositories;

namespace OnlineFoodOrderingSystem.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Order> AddAsync(OrderCreateDto dto)
        {
            var order = new Order
            {
                CustomerId = dto.CustomerId,
                TotalAmount = dto.TotalAmount,
                OrderDate = DateTime.Now
            };

            return await _repository.AddAsync(order);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var order = await _repository.GetByIdAsync(id);

            if (order == null)
                return false;

            await _repository.DeleteAsync(order);

            return true;
        }
    }
}