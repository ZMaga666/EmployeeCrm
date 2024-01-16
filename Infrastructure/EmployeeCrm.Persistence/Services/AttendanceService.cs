using AutoMapper;
using EmployeeCrm.Application.DTOs.AttendaceCreateDTO;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public  class AttendanceService:IAttendanceService
    {  
        private readonly IAttendanceReadRepository _AttendanceRead;
        private readonly IAttendanceWriteRepository _AttendanceWrite;
        private readonly IMapper _mapper;

        Task<int> IAttendanceService.CreateAttendance(AttendaceCreateDTO attendanceCreate)
        {
            throw new NotImplementedException();
        }

        List<AttendaceCreateDTO> IAttendanceService.GetEvents()
        {
            throw new NotImplementedException();
        }
    }
    
}
