using Cinema.Application.Common.Theaters.Dtos;
using Cinema.Application.Common.Theaters.Helpers;
using Cinema.Domain.AggregateModels.Theaters;

namespace Cinema.Application.Common.Theaters.UseCases.Impl;

public class TheaterUseCase : ITheaterUseCase
{
    private readonly ITheaterRepository repository;

    public TheaterUseCase(ITheaterRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<TheaterDto>> GetTheaters()
    {
        List<Theater> theaters = await repository.GetAllAsync();
        List<TheaterDto> theaterDtos = theaters.Select(theater => theater.TheaterToDto()).ToList();
        return theaterDtos;
    }
}
