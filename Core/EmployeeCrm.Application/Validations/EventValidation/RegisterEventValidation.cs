using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.EventValidation
{
    public class RegisterEventValidation : AbstractValidator<EventCreateDTO>
    {
        public RegisterEventValidation()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(6);
        }
    }
}
