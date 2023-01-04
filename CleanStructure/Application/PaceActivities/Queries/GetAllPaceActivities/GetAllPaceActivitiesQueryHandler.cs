using Application.Activities.Queries.GetAllActivities;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Queries.GetAllPaceActivities
{
    public class GetAllPaceActivitiesQueryHandler : IRequestHandler<GetAllPaceActivitiesQuery, List<PaceActivityDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllPaceActivitiesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<PaceActivityDTO>> Handle(GetAllPaceActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.PaceActivityRepository.GetPaceActivities();
            return _mapper.Map<List<PaceActivityDTO>>(activityList);
        }
    }
  
}
