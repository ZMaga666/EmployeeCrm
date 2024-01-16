using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.ExpenceTypeException
{
    public class ExpenceTypeNotValidate:Exception
    {
        public ExpenceTypeNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public ExpenceTypeNotValidate(string message) : base(message)
        {

        }

        public ExpenceTypeNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
