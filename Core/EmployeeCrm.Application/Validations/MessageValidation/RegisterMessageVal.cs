using EmployeeCrm.Application.DTOs.MessageDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.MessageValidation
{
    public class RegisterMessageVal:AbstractValidator<MessageCreateDTO>
    {
        public RegisterMessageVal()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(6);

        }
    }
}
