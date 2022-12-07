using System.Security.Claims;
using AuthenticationServices.Authentication;
using AuthenticationServices.Helpers;
using AuthenticationServices.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using Serilog;
using Soccer.Mq;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;

namespace Soccer.Api.Controllers;
[ApiController]
[Route("[controller]/[action]")]
[Authorize(AuthenticationSchemes = "Bearer")]
public class AuthController : ControllerBase
{
    private readonly IAuthentication<ApplicationUser> _auth;
    private readonly IMapper _mapper;
    private readonly Serilog.ILogger _logger;

    public AuthController(IAuthentication<ApplicationUser> auth, IMapper mapper, Serilog.ILogger logger)
    {
        _auth = auth;
        _mapper = mapper;
        _logger = logger;

    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Register(ApplicationUserDto applicationUserDto)
    {
        var user = _mapper.Map<ApplicationUser>(applicationUserDto);
        var result = await _auth.RegisterAsync(user, applicationUserDto.Password);
        if (!result.IsSuccess)
            return BadRequest(result);
        return Ok(result);
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> GetToken(Credentials credentials)
    {        // Console.WriteLine("+++++++++++++++++++=================>         " + recievedMessage);
        _logger.Information("GetToken");
        var result = await _auth.GetTokenAsync(credentials);
        if (!result.IsSuccess)
            return BadRequest(result);
        return Ok(result);
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> ForgotPassword([FromQuery] string username, string newPassword)
    {
        var results = await _auth.ForgotPasswordAsync(username, newPassword, Request.Host.Value);
        Log.Information(Request.Host.Value);
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
        _logger.Warning($"user '{User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault()!.ToString().Split()[^1]}' is trying to remove user '{username}' from role '{role}'");
        var results = await _auth.RemoveUserFromRoleAsync(username, role);
        if (!results.IsSuccess)
            return BadRequest(results);
        return Ok(results);
    }
    [Authorize(Roles = Roles.Admin)]
    [HttpGet]
    public IActionResult GetUsers()
    {
        var results = _auth.GetAllUsers();
        if (results == null)
            return BadRequest(results);
        return Ok(results.Select(u => _mapper.Map<ApplicationUserDto>(u)));
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
            return Ok(results.Select(u => _mapper.Map<ApplicationUserDto>(u)));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}