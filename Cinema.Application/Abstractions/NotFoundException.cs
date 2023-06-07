namespace Cinema.Application.Abstractions;

public class NotFoundException : ApplicationLayerException
{
    public NotFoundException(string? message) : base(message)
    {
    }
}
