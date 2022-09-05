using Microsoft.EntityFrameworkCore;
using Soccer.Shared;

namespace Soccer.Api.ServiceConfigurations;
public static class DbContextConfiguration
{
    public static IServiceCollection AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)
            , options => options.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        services.AddScoped<DbContext, ApplicationDbContext>();

        return services;
    }
}