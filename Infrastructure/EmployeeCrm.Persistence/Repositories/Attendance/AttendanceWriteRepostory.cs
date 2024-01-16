using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Context;
using EmployeeCrm.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories
{
    public class AttendanceWriteRepostory : WriteRepository<EmployeeCrm.Domain.Entities.Attendance>, IAttendanceWriteRepository
    {
        public AttendanceWriteRepostory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
