using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.AttendaceCreateDTO
{
    public class AttendaceCreateDTO
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public bool Attendance { get; set; } 
    }
}
