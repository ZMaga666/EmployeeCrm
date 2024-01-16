using EmployeeCrm.Application.DTOs.MessageDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IMessageService
    {
        Task<int> CreateMessage(MessageCreateDTO messageCreate);
        List<MessageDTO> GetMessages();
    }
}
