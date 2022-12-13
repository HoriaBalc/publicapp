using Application.Activities.Queries.GetActivityById;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Queries.GetDetailsActivityById
{
    public class GetDetailsActivityByIdQueryHandler : IRequestHandler<GetDetailsActivityByIdQuery, DetailActivity>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetDetailsActivityByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<DetailActivity> Handle(GetDetailsActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.DetailActivityRepository.GetDetailActivity(request.Id);
            return activity;
        }
    }
   
}
