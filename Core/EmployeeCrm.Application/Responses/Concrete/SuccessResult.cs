
using EmployeeCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Responses.Concrete

{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(bool success, string message) : base(true, message)
        {
        }
        public SuccessResult() : base(true) { }

    }
}
