using KonnClient.Services.Interfaces;

namespace KonnClient.Services;

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> SignIn(Models.SignIn data)
    {
        var response = await _httpClient.PostAsJsonAsync("/api/v1/account/signin", data);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> SignUp(Models.SignUp data)
    {
        var response = await _httpClient.PostAsJsonAsync("/api/v1/account/signup", data);
        return response.IsSuccessStatusCode;
    }
}
