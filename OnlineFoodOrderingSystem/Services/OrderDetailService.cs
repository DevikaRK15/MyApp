using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;
using OnlineFoodOrderingSystem.Repositories;

namespace OnlineFoodOrderingSystem.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _repository;

        public OrderDetailService(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<OrderDetail?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<OrderDetail> AddAsync(OrderDetailCreateDto dto)
        {
            var orderDetail = new OrderDetail
            {
                OrderId = dto.OrderId,
                FoodItemId = dto.FoodItemId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice
            };

            return await _repository.AddAsync(orderDetail);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await _repository.GetByIdAsync(id);

            if (item == null)
                return false;

            await _repository.DeleteAsync(item);

            return true;
        }
    }
}