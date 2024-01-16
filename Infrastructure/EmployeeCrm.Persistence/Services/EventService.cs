using AutoMapper;
using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DependecyResolver;
using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Responses;
using EmployeeCrm.Application.Responses.Abstract;
using EmployeeCrm.Application.Responses.Concrete;
using EmployeeCrm.Domain.Entities;
using EmployeeCrm.Persistence.Repository;
using FluentValidation;
using Npgsql.TypeMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Services
{
    


    public class EventService : IEventService
    {
        private readonly IEventReadRepository _eventRead;
        private readonly IEventWriteRepository _eventWrite;
        private readonly IMapper _mapper;
        private readonly IValidator<EventCreateDTO> _eventvalidator;

        public EventService(IEventReadRepository eventRead, IEventWriteRepository eventWrite, IMapper mapper, IValidator<EventCreateDTO> eventvalidator)
        {
            _eventRead = eventRead;
            _eventWrite = eventWrite;
            _mapper = mapper;
            _eventvalidator = eventvalidator;
        }



        
         public async Task<IResult> CreateEvent(EventCreateDTO eventCreate) 

        {

            var newEvent = _mapper.Map<Event>(eventCreate);
            var validation = _eventvalidator.Validate(eventCreate);
            if (!validation.IsValid)
            {
                return new ErrorResult("elave olunmadi");
              }
            await _eventWrite.AddAsync(newEvent);
            var res = await _eventWrite.SaveAsync();

            return new SuccessResult(true,"elave oldu");
            
         }

        List<EventDTO> IEventService.GetEvents()
        {

            var events = _eventRead.GetAll();
            if (events.Any()) throw new EventNotFoundException();
            var map = _mapper.Map<List<EventDTO>>(events);
            return map;
        }
    }
}
