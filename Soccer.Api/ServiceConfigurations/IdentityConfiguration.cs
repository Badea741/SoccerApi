using Microsoft.AspNetCore.Identity;
using Soccer.Shared.Entities;
using Soccer.Shared;

namespace Soccer.Api.ServiceConfigurations;
public static class IdentityConfiguration
{
    public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);

        return services;
    }
}