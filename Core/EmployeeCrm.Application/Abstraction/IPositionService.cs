using EmployeeCrm.Application.DTOs.PositionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IPositionService
    {
        Task<int> CreatePosition(PositonCreateDTO positonCreate);
        List<PositionDTO>GetPositions();
    }
}
