using Cinema.Application.Common.Theaters.Theaters.Dtos;
using Cinema.Domain.AggregateModels.Theaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.Theaters.Helpers;

public static class TheaterMapper
{
    public static TheaterDto TheaterToDto(this Theater theater)
    {
        return new TheaterDto
        {
            Id = theater.Id.Value,
            Name = theater.Name.Value,
            ProjectionTypes = theater.ProjectionTypes.Select(projectionType => projectionType.Name.Value).ToList(),
            Seats = theater.Seats.Select(seat => seat.Number.Value).ToList()
        };
    }
}
