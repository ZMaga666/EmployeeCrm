using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.InternShipException
{
    public class InternShipNotFoundEx:Exception
    {

        public InternShipNotFoundEx() : base("InternShip tapilmadi.")
        {

        }
        public InternShipNotFoundEx(string message) : base(message) { }

        public InternShipNotFoundEx(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
