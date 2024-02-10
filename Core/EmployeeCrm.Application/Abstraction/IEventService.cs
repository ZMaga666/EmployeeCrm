using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Responses;
using EmployeeCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeCrm.Application.Abstraction
{
    public interface IEventService
    {
        Task<IResult> CreateEvent(EventCreateDTO eventCreateDTO);
        public IDataResult<List<EventDTO>> GetEvents();
        public IDataResult<EventDTO> GetEventById(int id);
        Task<IResult> UpdateEvent(int id, EventUpdateDTO eventUpdateDTO);
        Task<IResult> DeleteEvent(int id);



    }
}
