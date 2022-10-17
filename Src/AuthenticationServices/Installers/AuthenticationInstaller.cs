using AuthenticationServices.Authentication;
using AuthenticationServices.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationServices.Installers;
public class AuthenticationInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IAuthentication<>), typeof(Authentication<>));
        services.AddScoped(typeof(UserManager<>), typeof(UserManager<>));
        services.Configure<Jwt>(configuration.GetSection("Jwt"));
    }
}