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
    public class EmployeeReadRepostory : ReadRepository<EmployeeCrm.Domain.Entities.Employee>, IEmployeeReadRepository
    {
        public EmployeeReadRepostory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
