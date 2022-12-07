using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Commands.DeleteSport
{
    public class DeleteSportHandler : IRequestHandler<DeleteSportCommand, Sport>
    {
        private readonly ISportRepository _sportRepository;

        public DeleteSportHandler(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public async Task<Sport> Handle(DeleteSportCommand request, CancellationToken cancellationToken)
        {
            var sport = await _sportRepository.GetSport(request.Name);
            await _sportRepository.DeleteSport(sport);
            return sport;
        }
    }
    
}
