﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs
{
    public class EmployeeCreateDTO
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public double Salary { get; set;}
        public DateTime StartWork { get; set; }
    }
}
