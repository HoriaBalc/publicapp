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
        private readonly ISportRepository _sportRepository;

        public GetSportByNameQueryHandler(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public async Task<Sport> Handle(GetSportByNameQuery request, CancellationToken cancellationToken)
        {
            var sport = await _sportRepository.GetSport(request.Name);
            return sport;

        }
    }
}
