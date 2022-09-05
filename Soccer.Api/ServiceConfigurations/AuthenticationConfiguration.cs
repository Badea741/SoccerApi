using System.Text;
using AuthenticationServices.Authentication;
using AuthenticationServices.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Soccer.Api.ServiceConfigurations;
public static class AuthenticationConfiguration
{
    public static IServiceCollection AddAuthenticationConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var jwt = new Jwt();
        configuration.GetSection("Jwt").Bind(jwt);
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
        {
            options.ForwardDefault = JwtBearerDefaults.AuthenticationScheme;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwt.Issuer,
                ValidAudience = jwt.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key))
            };
        });
        services.Configure<Jwt>(configuration.GetSection("Jwt"));
        services.AddScoped<IAuthentication, Authentication>();
        return services;
    }
}
