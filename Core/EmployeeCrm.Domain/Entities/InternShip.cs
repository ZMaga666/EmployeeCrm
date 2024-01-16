using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class InternShip:BaseEntitiy
    {public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
