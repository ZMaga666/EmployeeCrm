using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.ExpenceTypeException
{
    public class ExpenceTypeNotFoundex:Exception
    {

        public ExpenceTypeNotFoundex() : base("Event tapilmadi.")
        {

        }
        public ExpenceTypeNotFoundex(string message) : base(message) { }

        public ExpenceTypeNotFoundex(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
