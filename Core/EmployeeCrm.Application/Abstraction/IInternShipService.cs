using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.InternShipDTOs;
using EmployeeCrm.Application.DTOs.MeetingDTOs;
using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeCrm.Application.DTOs;


namespace EmployeeCrm.Application.Abstraction
{
    public interface IInternShipService
    {
        Task<int> CreateInternship(InternShipCreateDTO internShipCreate);
        List<InternShipDTO> GetInternShips();




    }
}
