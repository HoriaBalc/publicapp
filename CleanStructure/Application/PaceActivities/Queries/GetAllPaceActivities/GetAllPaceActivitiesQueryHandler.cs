using Application.Activities.Queries.GetAllActivities;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Queries.GetAllPaceActivities
{
    public class GetAllPaceActivitiesQueryHandler : IRequestHandler<GetAllPaceActivitiesQuery, List<PaceActivity>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetAllPaceActivitiesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<PaceActivity>> Handle(GetAllPaceActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.PaceActivityRepository.GetPaceActivities();
            return activityList;
        }
    }
  
}
