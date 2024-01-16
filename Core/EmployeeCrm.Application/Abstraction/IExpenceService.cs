using EmployeeCrm.Application.DTOs.ExpenceDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IExpenceService
    {
        Task<int>CreateExpence(ExpenceCreateDTO expenceCreateDTO);
        List<ExpenceDTO> GetExpences();
    }
}
