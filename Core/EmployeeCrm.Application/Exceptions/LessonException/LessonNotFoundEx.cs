using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.LessonException
{
    public class LessonNotFoundEx:Exception
    {
        public LessonNotFoundEx() : base("Lesson tapilmadi") 
        {
            
        }
        public LessonNotFoundEx(string message):base( message) { }
        public LessonNotFoundEx(string? message, Exception? innerException) : base(message, innerException) { }
        
                
        
    }
}

