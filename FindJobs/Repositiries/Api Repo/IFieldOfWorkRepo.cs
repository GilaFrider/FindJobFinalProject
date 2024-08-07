﻿using Repositiries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repositiries.Api_Repo
{
    public interface IFieldOfWorkRepo
    {
        List<FieldOfWork> GetAll();
        FieldOfWork GetByName(string name);
        FieldOfWork Create(FieldOfWork item);
    }
}
