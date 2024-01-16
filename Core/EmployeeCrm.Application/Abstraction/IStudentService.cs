using EmployeeCrm.Application.DTOs.StudentDTOs;
using EmployeeCrm.Application.DTOs.StudentPaymentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IStudentService
    {

        Task<int> CreateStudent(StudentCreateDTO StudentCreate);
        List<StudentDTO> GetStudentDTOs();
    }
}
