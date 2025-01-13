namespace MultyTestApp.Data;

public class UsersData
{
    private readonly List<User> _users = new()
    {
        new User { Id = 1, Name = "Egor", Email = "8kM5j@example.com" },
        new User { Id = 2, Name = "Ivan",Email = "8kM5j@example.com" },
        new User { Id = 3, Name = "Alex",Email = "8kM5j@example.com" },
        new User { Id = 4, Name = "Max",Email = "8kM5j@example.com" }
    };

    public IEnumerable<User> GetUsers() => _users;
}