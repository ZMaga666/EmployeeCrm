using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class StudentPayment:BaseEntitiy
    {
        public decimal Amount { get; set; }
        public bool PaymentMethod { get; set; }
    }
}
