namespace Cinema.Domain.AggregateModels.Users.ValueObjects;

public record UserEmail
{
    private const string mailPattern = "^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$";
    public string Value { get; init; }
    private UserEmail(string value) => Value = value;

    public static UserEmail Create(string value)
    {
        //if (!System.Text.RegularExpressions.Regex.IsMatch(value, mailPattern)) throw new EmailRegexException("Invalid email format.");
        return new UserEmail(value);
    }
}
