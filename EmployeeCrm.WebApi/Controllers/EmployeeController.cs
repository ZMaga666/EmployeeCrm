using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Persistence.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    { private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEmploye([FromBody] EmployeeCreateDTO employeeCreate)
        {
            var res = await _employeeService.CreateEmployee(employeeCreate);
            return Ok(res);
        }
        [HttpGet("events")]
        public IActionResult GetAllEvents()
        {
            var result = _employeeService.GetEmployees();
            return Ok(result);
        }
    }
}
