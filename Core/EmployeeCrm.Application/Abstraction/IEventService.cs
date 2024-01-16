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
        Task<IResult>  CreateEvent(EventCreateDTO eventCreate);
        List<EventDTO> GetEvents();
      //  Task<IResult> UpdateEvents(EventUpdateDTO eventUpdate);
      //  Task<IResult> DeleteEvents();
       // Task<IResult> DeleteAllEvents();

        
        
    }
}
