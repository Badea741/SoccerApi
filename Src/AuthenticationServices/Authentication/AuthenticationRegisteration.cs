using System.IdentityModel.Tokens.Jwt;
using AuthenticationServices.Helpers;
using AuthenticationServices.Models;
using Soccer.Shared.Entities;

namespace AuthenticationServices.Authentication;
public partial class Authentication
{
    public async Task<AuthenticationResults> RegisterAsync(RegisterModel registerModel)
    {
        if (await _userManager.FindByEmailAsync(registerModel.Email) != null)
            return new AuthenticationResults
            {
                Message = "Email is already in use",
            };
        if (await _userManager.FindByNameAsync(registerModel.Username) != null)
            return new AuthenticationResults
            {
                Message = "Username is already in use",
            };
        var user = _mapper.Map<ApplicationUser>(registerModel);
        var result = await _userManager.CreateAsync(user, registerModel.Password);
        var errorMessages = result.Errors.Select(e => e.Description);
        if (!result.Succeeded)
            return new AuthenticationResults
            {
                Message = String.Join(" , ", errorMessages),
            };
        await _userManager.AddToRoleAsync(user, Roles.User);
        return new AuthenticationResults
        {
            IsSuccess = true,
            Message = "User created successfully",
            Token = new JwtSecurityTokenHandler().WriteToken(await GenerateJwtTokenAsync(user)),
            Username = user.UserName,
            Roles = new List<string>() { Roles.User },
        };
    }
}