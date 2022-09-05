using AuthenticationServices.Helpers;
using Soccer.Shared.Entities;

namespace AuthenticationServices.Authentication;
public partial class Authentication
{
    public List<ApplicationUser> GetAllUsers()
    {
        return _userManager.Users.ToList();
    }
    public async Task<List<ApplicationUser>> GetUsersInRoleAsync(string role)
    {
        if (!Roles.AvailableRoles.Contains(role))
            throw new ArgumentException("Role does not exist");


        var users = await _userManager.GetUsersInRoleAsync(role);
        return users.ToList();
    }
}