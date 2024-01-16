using EmployeeCrm.Application.DTOs.LessonDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.LessonValidation
{
    public class RegisterLessonVal:AbstractValidator<LessonCreateDTO>
    {
        public RegisterLessonVal()
        {
            RuleFor(x => x.LessonName).NotEmpty().MaximumLength(6);

        }
    }
}
