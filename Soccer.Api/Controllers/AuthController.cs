using System.Web;
using AuthenticationServices.Authentication;
using AuthenticationServices.Helpers;
using AuthenticationServices.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Soccer.Api.Controllers;
[ApiController]
[Route("[controller]/[action]")]
[Authorize(AuthenticationSchemes = "Bearer")]
public class AuthController : ControllerBase
{
    private readonly IAuthentication _auth;

    public AuthController(IAuthentication auth)
    {
        _auth = auth;
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Register(RegisterModel model)
    {
        var result = await _auth.RegisterAsync(model);
        if (!result.IsSuccess)
            return BadRequest(result);
        return Ok(result);
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> GetToken(Credentials credentials)
    {
        var result = await _auth.GetTokenAsync(credentials);
        if (!result.IsSuccess)
            return BadRequest(result);
        return Ok(result);
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> ForgotPassword([FromQuery] string username, string newPassword)
    {
        var results = await _auth.ForgotPasswordAsync(username, newPassword);
        if (!results.IsSuccess)
            return BadRequest(results);
        return Ok(results);
    }
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> ResetPassword(string username, string token, string newPassword)
    {

        var results = await _auth.ResetPasswordAsync(username, token, newPassword);
        if (!results.IsSuccess)
            return BadRequest(results);
        return Ok(results);
    }
    [Authorize(Roles = Roles.Admin)]
    [HttpPost]
    public async Task<IActionResult> AddUserToRole([FromQuery] string username, string role)
    {
        var results = await _auth.AddUserToRoleAsync(username, role);
        if (!results.IsSuccess)
            return BadRequest(results);
        return Ok(results);
    }
    [Authorize(Roles = Roles.Admin)]
    [HttpDelete]
    public async Task<IActionResult> RemoveUserFromRole([FromQuery] string username, string role)
    {
        var results = await _auth.RemoveUserFromRoleAsync(username, role);
        if (!results.IsSuccess)
            return BadRequest(results);
        return Ok(results);
    }
    [Authorize(Roles = Roles.Admin, AuthenticationSchemes = "Bearer")]
    [HttpGet]
    public IActionResult GetUsers()
    {
        var results = _auth.GetAllUsers();
        if (results == null)
            return BadRequest(results);
        return Ok(results);
    }
    [Authorize(Roles = Roles.Admin)]
    [HttpGet]
    public async Task<IActionResult> GetUsersInRoles([FromQuery] string role)
    {
        try
        {
            var results = await _auth.GetUsersInRoleAsync(role);
            if (results == null)
                return BadRequest(results);
            return Ok(results);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}