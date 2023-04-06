using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Theaters.Seats;

public class Seat
{
    public SeatId Id { get; private set; }
    public SeatNumber Number { get; private set; }
    public TheaterId TheaterId { get; private set; }
    private Seat(SeatId id, SeatNumber number, TheaterId theaterId)
    {
        Id = id;
        Number = number;
        TheaterId = theaterId;
    }
    public static Seat Seed(SeatId id, SeatNumber number, TheaterId theaterId) => new(id, number, theaterId);
}
