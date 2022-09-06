using AutoMapper;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;

namespace Soccer.Shared.AutoMapperProfiles;
public class PlayerProfile : Profile
{
    public PlayerProfile()
    {
        CreateMap<Player, PlayerDto>().ReverseMap();
    }
}