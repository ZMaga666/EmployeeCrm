using EmployeeCrm.Application.DTOs.ExpenceDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.ExpenceValidation
{
    public class RegisterExpenceVal:AbstractValidator<ExpenceCreateDTO>
    {
        public RegisterExpenceVal()
        {
            RuleFor(x => x.Note).NotEmpty().MaximumLength(6);

        }
    }
}
