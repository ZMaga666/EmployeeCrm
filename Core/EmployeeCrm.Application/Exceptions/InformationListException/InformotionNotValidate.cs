using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.InformationListException
{
    public class InformotionNotValidate :Exception
    {

        public InformotionNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public InformotionNotValidate(string message) : base(message)
        {

        }

        public InformotionNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
