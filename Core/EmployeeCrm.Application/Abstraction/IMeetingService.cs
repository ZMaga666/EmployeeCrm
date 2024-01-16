using EmployeeCrm.Application.DTOs.MeetingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IMeetingService
    {
        Task<int> CreateMeeting(MeetingCreateDTO meetingCreate);
        List<MeetingDTO> GetMeeting();
    }
}
