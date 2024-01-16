using EmployeeCrm.Application.DTOs.RegisterBlankDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IRegisterBlank
    {
        Task<int> CreateRegister(RegisterBlankCreateDTO registerBlankCreate);
        List<RegisterBlankDTO> GetRegisterBlankDTOs();
    }
}
