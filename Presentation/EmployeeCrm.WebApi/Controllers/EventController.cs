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
        public async Task<IActionResult> CreateEvent([FromBody] EventCreateDTO eventCreate)
        {
            var res = await _eventService.CreateEvent(eventCreate);
            return Ok(res);
        }

        public async Task<IActionResult> UpdateEvents(int id, [FromBody] EventUpdateDTO eventUpdateDTO)
        {
            var result = await _eventService.UpdateEvent(id, eventUpdateDTO);
            return Ok(result);
        }


        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _eventService.DeleteEvent(id);
            return Ok(result);
        }

        [HttpGet("getallevents")]
        public IActionResult GetAllEvents()
        {
            var res = _eventService.GetEvents();
            return Ok(res);
        }
        [HttpGet("geteventbyid/{id}")]
        public IActionResult GetEventById(int id)
        {
            var res = _eventService.GetEventById(id);
            return Ok(res);
        }

    }
}
