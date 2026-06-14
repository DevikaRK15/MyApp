using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Services;

namespace OnlineFoodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _service.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await _service.GetByIdAsync(id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateDto dto)
        {
            var customer = await _service.AddAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = customer.CustomerId },
                customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            CustomerUpdateDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);

            if (!result)
                return NotFound();

            return Ok("Customer Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound();

            return Ok("Customer Deleted Successfully");
        }
    }
}