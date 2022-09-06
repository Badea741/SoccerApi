using FluentValidation;
using Soccer.Shared.Validations;

namespace Soccer.Api.ServiceConfigurations
{
    public static class FluentValidationConfiguration
    {
        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(TeamValidator).Assembly);
        }
    }
}