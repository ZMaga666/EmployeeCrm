using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class Task:BaseEntitiy
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
