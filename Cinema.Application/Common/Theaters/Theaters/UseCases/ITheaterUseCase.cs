using Cinema.Application.Common.Theaters.Theaters.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.Theaters.UseCases;

public interface ITheaterUseCase
{
    Task<List<TheaterDto>> GetTheaters();
}
