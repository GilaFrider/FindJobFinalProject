﻿using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Api_Service
{
    public interface IEmployerService:IRepositoryService<EmployerDTO>
    {
        EmployerDTO GetEmployerByEmail(string email);
    }
}
