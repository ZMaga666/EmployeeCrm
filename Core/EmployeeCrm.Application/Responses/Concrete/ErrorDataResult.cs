using EmployeeCrm.Application.Responses.Abstract;
using EmployeeCrm.Application.Responses.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Responses.Concrete

{
    public class ErrorDataResult<T> : DataResult<T>,IDataResult<T>
    {
        public ErrorDataResult(T data,  string message) : base(data, false, message)
        {
        }
        public ErrorDataResult(string message) : base( default,false,message) //?success
        {

        }

    }
}
