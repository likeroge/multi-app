using BlazorApp1.Models;

namespace BlazorApp1.Services;

public class UsersService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public UsersService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }
    public IEnumerable<User>? GetUsers()
    {
        var address = _configuration["BaseUrl"];
        return  _httpClient.GetFromJsonAsync<IEnumerable<User>>("Users").Result;
    }
}