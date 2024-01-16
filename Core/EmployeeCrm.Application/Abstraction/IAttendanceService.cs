using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeCrm.Application.DTOs.AttendaceCreateDTO;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IAttendanceService
    {

        Task<int> CreateAttendance(AttendaceCreateDTO attendanceCreate);
        List<AttendaceCreateDTO> GetEvents();
    }
}
