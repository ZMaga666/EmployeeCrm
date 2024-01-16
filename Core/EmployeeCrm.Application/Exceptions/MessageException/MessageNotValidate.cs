using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.MessageException
{
    public class MessageNotValidate:Exception
    {


        public MessageNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public MessageNotValidate(string message) : base(message)
        {

        }

        public MessageNotValidate(string message, Exception e) : base(message, e)
        {

        }




    }
}
