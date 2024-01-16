using EmployeeCrm.Application.DTOs.TaskDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface ITaskService
    {
        Task<int> CreateTask(TaskCreateDTO taskCreate);
        List<TaskDTO> GetTaskList();
    }
}
