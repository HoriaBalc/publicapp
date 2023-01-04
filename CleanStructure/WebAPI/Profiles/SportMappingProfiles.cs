using Application;
using AutoMapper;
using Domain;

namespace WebAPI.Profiles
{
    public class SportMappingProfiles : Profile
    {
        public SportMappingProfiles()
        {
            CreateMap<Sport, SportDTO>();

        }
    }
}
