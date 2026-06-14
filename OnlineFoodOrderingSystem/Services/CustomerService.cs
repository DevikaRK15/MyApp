using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Models;
using OnlineFoodOrderingSystem.Repositories;

namespace OnlineFoodOrderingSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Customer> AddAsync(CustomerCreateDto dto)
        {
            var customer = new Customer
            {
                FullName = dto.FullName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Address = dto.Address
            };

            return await _repository.AddAsync(customer);
        }

        public async Task<bool> UpdateAsync(int id, CustomerUpdateDto dto)
        {
            var customer = await _repository.GetByIdAsync(id);

            if (customer == null)
                return false;

            customer.FullName = dto.FullName;
            customer.Email = dto.Email;
            customer.PhoneNumber = dto.PhoneNumber;
            customer.Address = dto.Address;

            await _repository.UpdateAsync(customer);

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var customer = await _repository.GetByIdAsync(id);

            if (customer == null)
                return false;

            await _repository.DeleteAsync(customer);

            return true;
        }
    }
}