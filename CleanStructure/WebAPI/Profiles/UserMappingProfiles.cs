using Application;
using Application.Users;
using AutoMapper;
using Domain;

namespace WebAPI.Profiles
{
    public class UserMappingProfiles : Profile
    {
        public UserMappingProfiles()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

        }
    }
}
