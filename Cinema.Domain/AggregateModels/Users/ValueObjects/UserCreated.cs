using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Users.ValueObjects;

public record UserCreated
{
    public DateTime Value { get; init; }

    private UserCreated(DateTime value) => Value = value;

    public static UserCreated Create() => new(DateTime.Now);
    public static UserCreated CreateWithValue(DateTime value) => new(value);

    public override string ToString() => Value.ToString("ss:mm:hh dd/MM/yyyy");
}
