using EmployeeCrm.Application.DTOs.InformationListDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IInformationListService
    {
        Task<int> CreateInformationList(InformationListCreateDTO informationListCreate);
        List<InformationListDTO> GetInformationList();
    }
}
