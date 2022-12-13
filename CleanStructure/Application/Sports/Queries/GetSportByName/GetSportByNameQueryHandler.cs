using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GetSportByNameQueryHandler : IRequestHandler<GetSportByNameQuery, Sport>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetSportByNameQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Sport> Handle(GetSportByNameQuery request, CancellationToken cancellationToken)
        {
            var sport = await _unitOfWork.SportRepository.GetSport(request.Name);

            return sport;

        }
    }
}
