﻿using System;
using System.Collections.Generic;

namespace Repositiries.Models;

public partial class FieldOfWork
{
    public int Code { get; set; }

    public string FieldOfWorkName { get; set; } = null!;

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
}
