using Microsoft.AspNetCore.Mvc;
using MultyTestApp.Data;

namespace MultyTestApp.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UsersData _users;

    public UsersController(UsersData users)
    {
        _users = users;
    }

    /// <summary>
    /// Get a list of all users.
    /// </summary>
    /// <returns>A list of all users.</returns>
    [HttpGet]
    public  IEnumerable<User> GetAllUsers()
    {
        return _users.GetUsers();
    }
}