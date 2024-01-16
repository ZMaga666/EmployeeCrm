using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Context;
using EmployeeCrm.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Attendance
{
    public class AttendanceReadRepostory : ReadRepository<EmployeeCrm.Domain.Entities.Attendance>, IAttendanceReadRepository
    {
        public AttendanceReadRepostory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
