using Application.Activities.Queries.GetAllActivities;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Queries.GetAllDetailsActivities
{
    public class GetAllDetailsActivitiesQueryHandler : IRequestHandler<GetAllDetailsActivitiesQuery, List<DetailActivity>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetAllDetailsActivitiesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<DetailActivity>> Handle(GetAllDetailsActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.DetailActivityRepository.GetDetailActivities();
            return activityList;
        }
    }
    
}
