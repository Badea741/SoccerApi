using CommonGenericClasses;
using Soccer.Shared.Entities;
using Soccer.Shared.UnitsOfWork;

namespace Soccer.Api.ServiceConfigurations;

public static class UnitsOfWorkConfiguration
{
    public static IServiceCollection AddUnitsOfWork(this IServiceCollection services)
    {
        services.AddScoped<ITeamUnitOfWork, TeamUnitOfWork>();
        services.AddScoped<IPlayerUnitOfWork, PlayerUnitOfWork>();
        return services;
    }
}

