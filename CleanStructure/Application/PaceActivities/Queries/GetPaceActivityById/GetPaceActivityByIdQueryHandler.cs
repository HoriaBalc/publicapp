using Application.Activities.Queries.GetActivityById;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Queries.GetPaceActivityById
{
    public class GetPaceActivityByIdQueryHandler : IRequestHandler<GetPaceActivityByIdQuery, PaceActivityDTO>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetPaceActivityByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<PaceActivityDTO> Handle(GetPaceActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.PaceActivityRepository.GetPaceActivity(request.Id);
            return _mapper.Map<PaceActivityDTO>(activity);
        }
    }
    
}
