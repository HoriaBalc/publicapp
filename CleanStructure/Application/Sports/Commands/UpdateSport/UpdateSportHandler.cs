using Application.Sports.Commands.DeleteSport;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Commands.UpdateSport
{
    public class UpdateSportHandler : IRequestHandler<UpdateSportCommand, Sport>
    {
        private readonly ISportRepository _sportRepository;

        public UpdateSportHandler(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public async Task<Sport> Handle(UpdateSportCommand request, CancellationToken cancellationToken)
        {
            var sport = await _sportRepository.GetSport(request.Name);
            await _sportRepository.UpdateSport(sport);
            return sport;
        }
    }
   
}
