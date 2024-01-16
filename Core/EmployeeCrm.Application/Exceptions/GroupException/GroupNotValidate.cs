using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.GroupException
{
    public class GroupNotValidate:Exception
    {
        public GroupNotValidate() : base("Butun xanalari doldurun.")
        {
             
        }

        public GroupNotValidate(string message) : base(message)
        {

        }

        public GroupNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
