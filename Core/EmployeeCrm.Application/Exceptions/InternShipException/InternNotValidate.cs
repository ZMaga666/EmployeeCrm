using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.InternShipException
{
    public class InternNotValidate:Exception
    {

        public InternNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public InternNotValidate(string message) : base(message)
        {

        }

        public InternNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
