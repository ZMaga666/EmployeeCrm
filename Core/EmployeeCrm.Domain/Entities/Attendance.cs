using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class Attendance : BaseEntitiy
    {
        public DateTime lessondate { get; set; }
        public bool isAttendance { get; set; }
    }
}
