using AutoMapper;
using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Exceptions.EmployeeException;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Responses;
using EmployeeCrm.Application.Responses.Abstract;
using EmployeeCrm.Application.Responses.Concrete;
using EmployeeCrm.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public class EmployeeService : IEmployeeService

    {
        private readonly IMapper _mapper;
        private readonly IEmployeeWriteRepository _employeeWriteRepository;
        private readonly IEmployeeReadRepository _employeeReadRepository;
        private readonly IValidator<EmployeeCreateDTO> _employeevalidator;

        public EmployeeService(IEmployeeWriteRepository employeeWriteRepository, IEmployeeReadRepository employeeReadRepository, IValidator<EmployeeCreateDTO> employeevalidator, IMapper mapper)
        {
            _employeeWriteRepository = employeeWriteRepository;
            _employeeReadRepository = employeeReadRepository;
            _employeevalidator = employeevalidator;
            _mapper = mapper;
        }


        public List<EmployeeDTO> GetEmployees()
        {
            var employees=_employeeReadRepository.GetAll();
            if (!employees.Any()) throw new EmployeeNotFoundex();
            var map =_mapper.Map <List<EmployeeDTO>>( employees);
            return map; 




        }

       public async Task <IResult>  CreateEmployee(EmployeeCreateDTO employeeCreateDTO)
        {
            var newEmplyoee = _mapper.Map<Employee>(employeeCreateDTO);
            var validation = _employeevalidator.Validate(employeeCreateDTO);
            if (!validation.IsValid)
            {
                return new ErrorResult("Melumatlar tam elave olmayib");

            }
            await _employeeWriteRepository.AddAsync(newEmplyoee);
            var res = await _employeeWriteRepository.SaveAsync();
            return new SuccessResult(true, "Elave olundu");
        }
    }
}
