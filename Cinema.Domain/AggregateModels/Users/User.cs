using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Domain.AggregateModels.Users;

public class User
{
    public UserId Id { get; private set; }
    public UserFirstName FirstName { get; private set; }
    public UserLastName LastName { get; private set; }
    public Username Username { get; private set; }
    public UserEmail Email { get; private set; }
    public UserPassword Password { get; private set; }
    public UserCreated Created { get; private set; }
    public UserRole Role { get; private set; }

    private User(
        UserFirstName firstName,
        UserLastName lastName,
        Username username,
        UserEmail email,
        UserPassword password)
    {
        Id = new UserId(Guid.NewGuid());
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        Email = email;
        Password = password;
        Created = UserCreated.Create();
        Role = UserRole.Create();
    }

    public static User Create(
        UserFirstName firstName,
        UserLastName lastName,
        Username username,
        UserEmail email,
        UserPassword password)
    => new(firstName, lastName, username, email, password);

    public void Update(
        UserFirstName? firstName = null,
        UserLastName? lastName = null,
        UserPassword? password = null,
        UserRole? role = null)
    {
        if(firstName != null) FirstName = firstName;
        if(lastName != null) LastName = lastName;
        if(password != null) Password = password;
        if (role != null) Role = role;
    }
}

