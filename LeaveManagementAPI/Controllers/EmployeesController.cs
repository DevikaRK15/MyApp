using LeaveManagementAPI.Models;
using LeaveManagementAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _repository.GetAllAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _repository.GetByIdAsync(id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok("Employee Deleted Successfully");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != employee.EmployeeId)
                return BadRequest();

            await _repository.UpdateAsync(employee);

            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _repository.AddAsync(employee);

            return Ok(employee);
        }



    }
}