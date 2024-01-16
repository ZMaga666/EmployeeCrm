using EmployeeCrm.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IExpenceTypeService
    {
       Task<int> CreateExpenceType(ExpenceTypeCreateDTO expenceTypeCreateDTO);
        List<ExpenceTypeDTO> GetExpenceTypes();
    }
}
