﻿using Cinema.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Projections.Exceptions;

public class ProjectionNotFoundException : ApplicationLayerException
{
    public ProjectionNotFoundException(string? message) : base(message)
    {
    }
}
