using AutoMapper;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace EmployeeCrm.Application.Abstraction
{
    /*public class ExpenceService
    {
        private readonly IExpenceReadRepository _expenceRead;
        private readonly IExpenceWriteRepository _expenceWrite;
        private readonly IMapper _mapper;

      /*  public ExpenceService(IEventReadRepository eventRead, IEventWriteRepository eventWrite, IMapper mapper)
        {
            _expenceRead = expenceRead;
            _eventWrite = eventWrite;
            _mapper = mapper;
        }

        public async Task<int> CreateEvent(EventDTO eventCreate)
        {
            var newEvent = _mapper.Map<Event>(eventCreate);
            await _eventWrite.AddAsync(newEvent);
            var res = await _eventWrite.SaveAsync();
            return res;

        }

        public List<EventDTO> GetEvents()
        {
            var events = _eventRead.GetAll();
            if (events.Any()) throw new EventNotFoundException();
            var map = _mapper.Map<List<EventDTO>>(events);
            return map;
        }
    }
}*/
