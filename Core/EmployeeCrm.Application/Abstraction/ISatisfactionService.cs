using EmployeeCrm.Application.DTOs.RoleDTOs;
using EmployeeCrm.Application.DTOs.SatisfactionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface ISatisfactionService
    {

        Task<int> CreateSatisfaction(SatisfactionCreateDTO SatisfactionCreate);
        List<SatisfactionDTO> GetSatisfactionDTOs();
    }
}
