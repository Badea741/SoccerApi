using AutoMapper;
using Soccer.Shared.StringExtensions;

namespace Soccer.Shared.AutoMapperProfiles;
public class TeamProfile : Profile
{
    public TeamProfile()
    {
        CreateMap<Team, TeamDto>().ForMember(s => s.Logo, opt => opt.MapFrom(src => src.Logo!.ToBase64())); ;
        CreateMap<TeamDto, Team>().ForMember(s => s.Logo, opt => opt.MapFrom(src => src.Logo!.ToByteArray()));
    }
}