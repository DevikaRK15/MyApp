using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.DTOs;
using OnlineFoodOrderingSystem.Services;

namespace OnlineFoodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var order = await _service.GetByIdAsync(id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderCreateDto dto)
        {
            var order = await _service.AddAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = order.OrderId },
                order);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound();

            return Ok("Order Deleted Successfully");
        }
    }
}