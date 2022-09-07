using AutoMapper;
using Soccer.Shared.StringExtensions;

namespace Soccer.Shared.AutoMapperProfiles;
public class PlayerProfile : Profile
{
    public PlayerProfile()
    {
        CreateMap<Player, PlayerDto>().ForMember(s => s.Image, opt => opt.MapFrom(src => src.Image!.ToBase64()));

        CreateMap<PlayerDto, Player>().ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image!.ToByteArray()));

    }
}