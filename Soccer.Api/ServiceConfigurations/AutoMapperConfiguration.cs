using AuthenticationServices.Models;
using AutoMapper;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;

namespace Soccer.Api.ServiceConfigurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.CreateMap<Team, TeamDto>().ReverseMap();
                mc.CreateMap<Player, PlayerDto>().ReverseMap();
                mc.CreateMap<RegisterModel, ApplicationUser>().ReverseMap();
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}