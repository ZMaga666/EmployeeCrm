using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.EmployeeException
{
    public class EmployeeNotValidateex:Exception
    {
        public EmployeeNotValidateex() : base("Butun xanalari doldurun.")
        {

        }

        public EmployeeNotValidateex(string message) : base(message)
        {

        }

        public EmployeeNotValidateex(string message, Exception e) : base(message, e)
        {

        }
    }

}
