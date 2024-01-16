using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Domain.Entities;
using EmployeeCrm.Persistence.Context;
using EmployeeCrm.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories
{
    public class EmployeeWriteRepostory : WriteRepository<EmployeeCrm.Domain.Entities.Employee>, IEmployeeWriteRepository
    {
        public EmployeeWriteRepostory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
