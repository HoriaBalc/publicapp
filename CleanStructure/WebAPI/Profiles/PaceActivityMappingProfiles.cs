using Application.Activities;
using Application.PaceActivities;
using AutoMapper;
using Application.DTOs;
using Domain;

namespace WebAPI.Profiles
{
    public class PaceActivityMappingProfiles : Profile
    {
        public PaceActivityMappingProfiles()
        {
            CreateMap<PaceActivityDTOCreateUpdate, PaceActivityDTO>();
            CreateMap<PaceActivity, PaceActivityDTO>();
            CreateMap<PaceActivityDTO, PaceActivity>();

        }

    }
}
