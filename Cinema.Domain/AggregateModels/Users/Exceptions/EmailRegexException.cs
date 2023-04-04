﻿using Cinema.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Users.Exceptions;

public class EmailRegexException : DomainException
{
    public EmailRegexException(string message) : base(message)
    {
    }
}