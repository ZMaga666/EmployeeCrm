using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.EmployeeException
{
    public class EmployeeNotFoundex:Exception
    {

        public EmployeeNotFoundex() : base("Employee tapilmadi.")
        {

        }
       
            
        public EmployeeNotFoundex(string message) : base(message) { }

        public EmployeeNotFoundex(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
