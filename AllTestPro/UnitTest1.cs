using System.Net.Http.Json;
using MultyTestApp.Data;
using Xunit.Abstractions;

namespace AllTestPro;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        var a = 1;
        var b = 2;

        Assert.Equal(3, a + b);
    }

    [Fact]
    public void Test2()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:5010/api/");
        // return  _httpClient.GetFromJsonAsync<IEnumerable<User>>("Users").Result;

        var users = httpClient.GetFromJsonAsync<IEnumerable<User>>("Users").Result;
        Assert.True(users?.Any());
    }
}