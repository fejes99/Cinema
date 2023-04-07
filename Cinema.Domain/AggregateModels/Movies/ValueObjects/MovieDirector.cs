namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieDirector
{
    public string Value { get; init; }
    private MovieDirector(string value) => Value = value;
    public static MovieDirector? Create(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        return new MovieDirector(value);
    }
}
