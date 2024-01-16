using EmployeeCrm.Application.DTOs.RoleDTOs;
using EmployeeCrm.Application.DTOs.StudentPaymentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IStudentPaymentService
    {

        Task<int> CreateStudentPayment(StudentPaymentCreateDTO StudentPaymentCreate);
        List<StudentPaymentDTO> GetStudentPaymentDTOs();
    }
}
