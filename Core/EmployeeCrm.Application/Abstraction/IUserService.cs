using EmployeeCrm.Application.DTOs.StudentPaymentDTOs;
using EmployeeCrm.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IUserService
    {

        Task<int> CreateUser(UserCreateDTO userCreate);
        List<UserDTO> GetUsers();
    }
}
