using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.ExpenceTypeValidation
{
    public class RegisterExpenceTypeval : AbstractValidator<ExpenceTypeCreateDTO>
    {

        public RegisterExpenceTypeval()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(6);
        }
    }
}
