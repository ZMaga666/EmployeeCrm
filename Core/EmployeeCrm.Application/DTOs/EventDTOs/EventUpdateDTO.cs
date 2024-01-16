using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.EventDTos
{
    public class EventUpdateDTO
    {

        public string Title { get; set; }
        public string Location { get; set; }
        public string Organizator { get; set; }
        public DateTime EventTime { get; set; }

    }
}
