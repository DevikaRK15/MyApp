using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllAsync();

        Task<Customer?> GetByIdAsync(int id);

        Task<Customer> AddAsync(CustomerCreateDto dto);

        Task<bool> UpdateAsync(int id, CustomerUpdateDto dto);

        Task<bool> DeleteAsync(int id);
    }
}