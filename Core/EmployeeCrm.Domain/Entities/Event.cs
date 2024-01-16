using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class Event : BaseEntitiy
    {
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Organizator { get; set; }
    }
}
