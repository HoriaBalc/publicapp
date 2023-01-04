using Application.Activities.Queries.GetActivityById;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Queries.GetDetailsActivityById
{
    public class GetDetailsActivityByIdQueryHandler : IRequestHandler<GetDetailsActivityByIdQuery, DetailActivityDTO>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetDetailsActivityByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<DetailActivityDTO> Handle(GetDetailsActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.DetailActivityRepository.GetDetailActivity(request.Id);
            return _mapper.Map<DetailActivityDTO>(activity);
        }
    }
   
}
