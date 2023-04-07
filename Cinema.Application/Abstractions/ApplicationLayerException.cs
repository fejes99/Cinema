namespace Cinema.Application.Abstractions;

public abstract class ApplicationLayerException : Exception
{
    protected ApplicationLayerException(string? message) : base(message)
    {
    }
}
