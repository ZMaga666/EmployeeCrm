using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.MeetingException
{
    public class MeetingNotValidate:Exception
    {

        public MeetingNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public MeetingNotValidate(string message) : base(message)
        {

        }

        public MeetingNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
