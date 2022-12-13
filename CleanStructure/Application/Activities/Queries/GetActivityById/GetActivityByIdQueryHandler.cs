using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetActivityById
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, Activity>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetActivityByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Activity> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.ActivityRepository.GetActivity(request.Id);
            return activity;
        }
    }
    
}
