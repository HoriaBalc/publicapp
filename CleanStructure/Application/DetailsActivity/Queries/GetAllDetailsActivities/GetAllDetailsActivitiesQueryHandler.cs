using Application.Activities.Queries.GetAllActivities;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Queries.GetAllDetailsActivities
{
    public class GetAllDetailsActivitiesQueryHandler : IRequestHandler<GetAllDetailsActivitiesQuery, List<DetailActivityDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllDetailsActivitiesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<DetailActivityDTO>> Handle(GetAllDetailsActivitiesQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.DetailActivityRepository.GetDetailActivities();
            return _mapper.Map<List<DetailActivityDTO>>(activityList);
        }
    }
    
}
