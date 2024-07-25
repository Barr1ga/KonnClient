namespace KonnClient.Services.Interfaces;

public interface IUserService
{
    Task<bool> SignIn(Models.SignIn data);
    Task<bool> SignUp(Models.SignUp data);
}