namespace Cinema.Infrastructure.Abstractions;

public class InfrastructureException : Exception
{
    public InfrastructureException(string message) : base(message)
    {
    }
}
