using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.ExpenceException
{
    public class ExpenceNotFoundex:Exception
    {

        public ExpenceNotFoundex() : base("Event tapilmadi.")
        {

        }
        public ExpenceNotFoundex(string message) : base(message) { }

        public ExpenceNotFoundex(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
