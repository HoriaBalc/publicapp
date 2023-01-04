using Application.Sports.Queries.GetAllSports;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetAllActivities
{
    public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, List<ActivityDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetAllActivitiesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<ActivityDTO>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.ActivityRepository.GetActivities();
            return _mapper.Map<List<ActivityDTO>>(activityList);
        }
    }
    
}
