using System.IdentityModel.Tokens.Jwt;
using AuthenticationServices.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Soccer.Shared.Entities;
namespace AuthenticationServices.Authentication;
public partial class Authentication : IAuthentication
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMapper _mapper;
    private readonly Jwt _jwt;
    public Authentication(UserManager<ApplicationUser> userManager, IMapper mapper, IOptions<Jwt> jwt)
    {
        _userManager = userManager;
        _mapper = mapper;
        _jwt = jwt.Value;
    }

    public async Task<AuthenticationResults> GetTokenAsync(Credentials credentials)
    {
        AuthenticationResults results = new AuthenticationResults();
        var user = await _userManager.FindByNameAsync(credentials.UserName);
        if (user == null || !await _userManager.CheckPasswordAsync(user, credentials.Password))
        {
            results.Message = "Username or password is incorrect";
            return results;
        }
        var userRoles = await _userManager.GetRolesAsync(user) as List<string>;
        var token = await GenerateJwtTokenAsync(user);
        results.IsSuccess = true;
        results.Message = "Signed in successfully";
        results.Username = user.UserName;
        results.Token = new JwtSecurityTokenHandler().WriteToken(token);
        results.Roles = userRoles;

        return results;
    }

}