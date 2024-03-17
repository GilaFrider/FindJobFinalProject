﻿using System;
using System.Collections.Generic;

namespace DataBase.Models;

public partial class Job
{
    public int Code { get; set; }

    public int EmployersCode { get; set; }

    public int FieldOfWorkCode { get; set; }

    public int CriteriaCode { get; set; }

    public virtual CriterionDTO CriteriaCodeNavigation { get; set; } = null!;

    public virtual EmployerDTO EmployersCodeNavigation { get; set; } = null!;

    public virtual FieldOfWorkDTO FieldOfWorkCodeNavigation { get; set; } = null!;
}
