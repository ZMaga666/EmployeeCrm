using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.ExpenceDTOs
{
    public class ExpenceCreateDTO
    {
        public int ExpenseTypeId { get; set; }
        public string? Note { get; set;}
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }


    }
}
