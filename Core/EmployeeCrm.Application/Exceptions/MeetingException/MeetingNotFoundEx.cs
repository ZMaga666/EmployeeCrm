using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.MeetingException
{
    public class MeetingNotFoundEx:Exception
    {
        public MeetingNotFoundEx() : base("Meeting tapilmadi")
        {

        }
        public MeetingNotFoundEx(string message) : base(message) { }
        public MeetingNotFoundEx(string? message, Exception? innerException) : base(message, innerException) { }



    }
}
