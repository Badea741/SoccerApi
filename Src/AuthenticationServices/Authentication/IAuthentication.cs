using AuthenticationServices.Models;
using Soccer.Shared.Entities;

namespace AuthenticationServices.Authentication;

public interface IAuthentication
{
    Task<AuthenticationResults> RegisterAsync(RegisterModel registerModel);
    Task<AuthenticationResults> GetTokenAsync(Credentials credentials);
    Task<AuthenticationResults> ForgotPasswordAsync(string username, string newPassword);
    Task<AuthenticationResults> ResetPasswordAsync(string username, string token, string newPassword);
    Task<AuthenticationResults> AddUserToRoleAsync(string username, string role);
    Task<AuthenticationResults> RemoveUserFromRoleAsync(string username, string role);
    List<ApplicationUser> GetAllUsers();
    Task<List<ApplicationUser>> GetUsersInRoleAsync(string role);

}