using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.ExpenceException
{
    public class ExpenceNotValidate : Exception
    {

        public ExpenceNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public ExpenceNotValidate(string message) : base(message)
        {

        }

        public ExpenceNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
