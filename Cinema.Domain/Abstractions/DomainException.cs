﻿namespace Cinema.Domain.Abstractions;

public abstract class DomainException : Exception
{
    public DomainException(string message) : base(message)
    {
    }
}
