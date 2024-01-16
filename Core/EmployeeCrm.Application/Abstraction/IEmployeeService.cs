using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.Responses;
using EmployeeCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IEmployeeService
    {
        Task<IResult> CreateEmployee (EmployeeCreateDTO employeeCreateDTO);
        List<EmployeeDTO> GetEmployees();
    }
}
