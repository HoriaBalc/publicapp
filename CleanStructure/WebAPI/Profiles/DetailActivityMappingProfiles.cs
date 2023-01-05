using Application.Activities;
using Application.DetailsActivity;
using Application.DTOs;
using AutoMapper;
using Domain;

namespace WebAPI.Profiles
{
    public class DetailActivityMappingProfiles : Profile
    {
        public DetailActivityMappingProfiles()
        {
            CreateMap<DetailsActivityDTOCreateUpdate, DetailActivityDTO>();
            CreateMap<DetailActivity, DetailActivityDTO>();
            CreateMap<DetailActivityDTO, DetailActivity>();

        }
    }
}
