using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Context;
using EmployeeCrm.Persistence.Repository;
using EmployeeCrm.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories
{
    public class EventWriteRepostory : WriteRepository<EmployeeCrm.Domain.Entities.Event>, IEventWriteRepository

    {
        public EventWriteRepostory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
