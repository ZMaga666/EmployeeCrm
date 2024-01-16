
using EmployeeCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Responses.Concrete

{
    public class ErrorResult : Result, IResult
    {
        public ErrorResult( string message) : base(false , message)
        {
        }
        public ErrorResult() : base(false)
        {

        }
    }
}
