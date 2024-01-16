using AutoMapper;
using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Responses;
using EmployeeCrm.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public class ExpenceTypeService : IExpenceTypeService
    {
        private readonly IMapper _mapper;
        private readonly IExpenceTypeReadRepository _expenceTypeRead;
        private readonly IExpenceTypeWriteRepository _expenceTypeWrite;
        private readonly IValidator<ExpenceTypeCreateDTO> _expencevalidator;

        public ExpenceTypeService(IValidator<ExpenceTypeCreateDTO> expencevalidator, IExpenceTypeWriteRepository expenceTypeWrite, IExpenceTypeReadRepository expenceTypeRead, IMapper mapper)
        {
            _expencevalidator = expencevalidator;
            _expenceTypeWrite = expenceTypeWrite;
            _expenceTypeRead = expenceTypeRead;
            _mapper = mapper;
        }

        public async Task<int> CreateExpenceType(ExpenceTypeCreateDTO expenceTypeCreate)
        { var newExpenceType = _mapper.Map<ExpenceType>(expenceTypeCreate);
            var validation = _expencevalidator.Validate(expenceTypeCreate);
            if(!validation.IsValid)
            {
              //  throw new Result(false, validation.Errors.Select(x => x.ErrorMessage).ToList());
              
                
            }
            await _expenceTypeWrite.AddAsync(newExpenceType);
            var res = await _expenceTypeWrite.SaveAsync();
            //  return new Result(true, "Elave olundu");
            return res;




        }

        List<ExpenceTypeDTO> IExpenceTypeService.GetExpenceTypes()
        {
            throw new NotImplementedException();
        }
    }
}
