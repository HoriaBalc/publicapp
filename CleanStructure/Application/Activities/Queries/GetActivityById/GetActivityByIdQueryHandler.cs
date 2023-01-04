using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetActivityById
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, ActivityDTO>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetActivityByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<ActivityDTO> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.ActivityRepository.GetActivity(request.Id);
            return _mapper.Map<ActivityDTO>(activity);
        }
    }
    
}
