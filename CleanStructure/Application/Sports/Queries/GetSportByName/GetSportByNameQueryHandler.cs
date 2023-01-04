using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GetSportByNameQueryHandler : IRequestHandler<GetSportByNameQuery, SportDTO>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetSportByNameQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;   
        }


        public async Task<SportDTO> Handle(GetSportByNameQuery request, CancellationToken cancellationToken)
        {
            var sport = await _unitOfWork.SportRepository.GetSport(request.Name);

            return _mapper.Map<SportDTO>(sport);

        }
    }
}
