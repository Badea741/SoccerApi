using AuthenticationServices.Helpers;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationServices.Authentication;
public partial class Authentication<TUser> where TUser : IdentityUser
{
    public List<TUser> GetAllUsers()
    {
        return _userManager.Users.AsParallel().ToList();
    }
    public virtual async Task<List<TUser>> GetUsersInRoleAsync(string role)
    {
        if (!Roles.AvailableRoles.Contains(role))
            throw new ArgumentException("Role does not exist");


        var users = await _userManager.GetUsersInRoleAsync(role);
        return users.AsParallel().ToList();
    }
}