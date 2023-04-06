using Cinema.Application.Common.Theaters.Theaters.Dtos;
using Cinema.Application.Common.Theaters.Theaters.Helpers;
using Cinema.Domain.AggregateModels.Theaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.Theaters.UseCases.Impl;

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
