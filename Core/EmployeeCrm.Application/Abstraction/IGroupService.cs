using EmployeeCrm.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IGroupService
    {
        Task<int> CreateGroup(GroupCreateDTO createDTO);
        List<GroupDTO> GetGroups();

    }
}
