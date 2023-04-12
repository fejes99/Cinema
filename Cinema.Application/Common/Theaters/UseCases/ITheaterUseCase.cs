using Cinema.Application.Common.Theaters.Dtos;

namespace Cinema.Application.Common.Theaters.UseCases;

public interface ITheaterUseCase
{
    Task<List<TheaterDto>> GetTheaters();
}
