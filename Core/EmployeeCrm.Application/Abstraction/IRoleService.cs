using EmployeeCrm.Application.DTOs.RegisterBlankDTOs;
using EmployeeCrm.Application.DTOs.RoleDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IRoleService
    {

        Task<int> CreateRole(RoleCreateDTO roleCreate);
        List<RoleDTO> GetRoleDTOs();
    }
}
