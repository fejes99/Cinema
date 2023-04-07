using Cinema.Application.Common.Theaters.Theaters.Dtos;

namespace Cinema.Application.Common.Theaters.Theaters.UseCases;

public interface ITheaterUseCase
{
    Task<List<TheaterDto>> GetTheaters();
}
