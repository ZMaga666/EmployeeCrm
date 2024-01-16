using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
       private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateEvent([FromBody]EventCreateDTO eventCreate)
        {
            var res =await _eventService.CreateEvent(eventCreate);
            return Ok(res);
        }
        [HttpGet("events")]
        public IActionResult GetAllEvents() 
        {
            var result = _eventService.GetEvents();
            return Ok(result);
        }
    }
}
