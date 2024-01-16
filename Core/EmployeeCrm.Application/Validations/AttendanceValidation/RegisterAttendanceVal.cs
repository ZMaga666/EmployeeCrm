using EmployeeCrm.Application.DTOs.AttendaceCreateDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.AttendanceValidation
{
   public class RegisterAttendanceVal:AbstractValidator<AttendaceCreateDTO>
    {
        public RegisterAttendanceVal()
        {
           // RuleFor(x => x.).NotEmpty().MaximumLength(6);

        }
    }
}
