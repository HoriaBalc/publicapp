using Application.Activities;
using Application.Users.Queries.GetAllActivitiesFromUser;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Queries.GetAllActivitiesFromSport
{
    public class GetAllActivitiesFromSportQueryHandler : IRequestHandler<GetAllActivitiesFromSportQuery, List<ActivityDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllActivitiesFromSportQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<List<ActivityDTO>> Handle(GetAllActivitiesFromSportQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.ActivityRepository.GetActivities();
            var activitiesOfSport= new List<ActivityDTO>();
            activityList.ForEach(a =>
            {
                if (a.Sport.Name == request.Name)
                    activitiesOfSport.Add(_mapper.Map<ActivityDTO>(a));
            });
            return activitiesOfSport;

        }
    }
    
}
