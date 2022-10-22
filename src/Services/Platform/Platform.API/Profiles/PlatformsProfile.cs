using AutoMapper;
using Platform.API.Dtos;
using Platform.API.Models;

namespace Platform.API.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Models.Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Models.Platform>();
        }
    }
}
