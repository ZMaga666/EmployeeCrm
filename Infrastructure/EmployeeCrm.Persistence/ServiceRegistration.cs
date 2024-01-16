using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Context;
using EmployeeCrm.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        { 
            services.AddDbContext<AppDbContext>(option => option.UseNpgsql(Configuration.ConnectionString));

             services.AddScoped<IEventReadRepository,EventReadRepostory>();
            services.AddScoped<IEventWriteRepository,EventWriteRepostory>();
        }
    }
}
