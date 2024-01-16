using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.GroupException
{
    public class GroupNotFoundex:Exception
    {

        public GroupNotFoundex() : base("Group tapilmadi.")
        {

        }
        public GroupNotFoundex(string message) : base(message) { }

        public GroupNotFoundex(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
