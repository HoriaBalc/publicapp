using Application;
using AutoMapper;
using Domain;

namespace WebAPI.Profiles
{
    public class RoleMappingProfiles : Profile
    {
        public RoleMappingProfiles() {
            CreateMap<Role, RoleDTO>();
            CreateMap<RoleDTO, Role>();
        }
    }
}
