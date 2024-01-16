using EmployeeCrm.Application.DTOs.StudentDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.StudentValidation
{
    public class RegisterStudentVal:AbstractValidator<StudentCreateDTO>
    {
        public RegisterStudentVal()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(6);

        }
    }
}
