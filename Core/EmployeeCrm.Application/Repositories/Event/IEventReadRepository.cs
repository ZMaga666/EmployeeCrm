﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeCrm.Domain.Entities;


namespace EmployeeCrm.Application.Repositories
{
    public interface IEventReadRepository:IReadRepository<Event>
    {
    }
}
