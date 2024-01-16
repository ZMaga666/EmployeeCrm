using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.GroupException
{
    public class InformotionNotFoundEx:Exception
    {

        public InformotionNotFoundEx() : base("Information tapilmadi.")
        {

        }
        public InformotionNotFoundEx(string message) : base(message) { }

        public InformotionNotFoundEx(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
