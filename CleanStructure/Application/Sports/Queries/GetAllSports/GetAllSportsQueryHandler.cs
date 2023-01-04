using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Queries.GetAllSports
{
    public class GetAllSportsQueryHandler : IRequestHandler<GetAllSportsQuery, List<SportDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllSportsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<SportDTO>> Handle(GetAllSportsQuery request, CancellationToken cancellationToken)
        {
            var sportList = await _unitOfWork.SportRepository.GetSports();

            return _mapper.Map<List<SportDTO>>(sportList);

        }
    }
    
}
