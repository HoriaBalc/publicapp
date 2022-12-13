using Application.Activities.Queries.GetActivityById;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Queries.GetPaceActivityById
{
    public class GetPaceActivityByIdQueryHandler : IRequestHandler<GetPaceActivityByIdQuery, PaceActivity>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetPaceActivityByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PaceActivity> Handle(GetPaceActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.PaceActivityRepository.GetPaceActivity(request.Id);
            return activity;
        }
    }
    
}
