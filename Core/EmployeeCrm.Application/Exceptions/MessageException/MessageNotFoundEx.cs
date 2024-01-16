using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.MessageException
{
    public class MessageNotFoundEx:Exception
    {
        public MessageNotFoundEx():base("Message tapilmadi")
        {

        }
        public MessageNotFoundEx(string message):base(message) { }

        public MessageNotFoundEx(string message, Exception innerException):base(message, innerException) { }

        
    }
}
