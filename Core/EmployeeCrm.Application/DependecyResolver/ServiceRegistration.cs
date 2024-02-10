using AutoMapper;
using EmployeeCrm.Application.AutoMapper;
using EmployeeCrm.Application.DTOs;
using EmployeeCrm.Application.DTOs.EventDTos;
using EmployeeCrm.Application.Validations.EventValidation;
using EmployeeCrm.Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DependecyResolver
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IValidator<EventCreateDTO>, RegisterEventValidation>();
        }
    }

        
}
