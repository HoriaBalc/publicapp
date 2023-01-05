using Application;
using Application.Activities;
using AutoMapper;
using Domain;
using Application.DTOs;

namespace WebAPI.Profiles
{
    public class ActivityMappingProfiles : Profile
    {
        public ActivityMappingProfiles()
        {
            CreateMap<ActivityDTOCreateUpdate, ActivityDTO>();
            CreateMap<Activity, ActivityDTO>();
            CreateMap<ActivityDTO, Activity>();

        }
    }
    
}
