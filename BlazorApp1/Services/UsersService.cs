using BlazorApp1.Models;

namespace BlazorApp1.Services;

public class UsersService
{
    private readonly HttpClient _httpClient;

    public UsersService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public IEnumerable<User>? GetUsers()
    {
        return  _httpClient.GetFromJsonAsync<IEnumerable<User>>("Users").Result;
    }
}