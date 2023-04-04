using Cinema.Application.Abstractions;
using Cinema.Application.Common.Movies.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.UseCases;

public interface IGetMoviesUseCase : IUseCase<object, List<MovieDto>>
{
}
