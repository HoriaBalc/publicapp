using Application.Sports.Queries.GetAllSports;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetAllActivities
{
    public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, List<Activity>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetAllActivitiesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<Activity>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.ActivityRepository.GetActivities();
            return activityList;
        }
    }
    
}
