using EmployeeCrm.Application.DTOs.LessonDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface ILessonService
    {
        Task<int> CreateLesson(LessonCreateDTO createDTO);
        List<LessonDTO> GetLessons();
    }
}
