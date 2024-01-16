using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.LessonException
{
    public class LessonNotValidate:Exception
    {

        public LessonNotValidate() : base("Butun xanalari doldurun.")
        {

        }

        public LessonNotValidate(string message) : base(message)
        {

        }

        public LessonNotValidate(string message, Exception e) : base(message, e)
        {

        }
    }
}
