using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Responses.Abstract

{
    public interface IDataResult<T>
    {
        public T Data { get; }
    }
}
