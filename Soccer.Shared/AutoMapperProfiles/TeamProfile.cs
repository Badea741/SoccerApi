using AutoMapper;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;

namespace Soccer.Shared.AutoMapperProfiles;
public class TeamProfile : Profile
{
    public TeamProfile()
    {
        CreateMap<Team, TeamDto>().ReverseMap();
    }
}