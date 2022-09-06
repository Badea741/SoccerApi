using AutoMapper;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;

namespace Soccer.Shared.AutoMapperProfiles;
public class ApplicationUserProfile : Profile
{
    public ApplicationUserProfile()
    {
        CreateMap<ApplicationUserDto, ApplicationUser>().ReverseMap();
    }
}