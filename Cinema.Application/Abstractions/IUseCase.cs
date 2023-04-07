namespace Cinema.Application.Abstractions;

public interface IUseCase<in TRequest, TResponse>
{
    Task<TResponse> Execute(TRequest request);
}

