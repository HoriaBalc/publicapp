using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Commands.CreateSport
{
    public class CreateSportHandler : IRequestHandler<CreateSportMessage, Guid>
    {
        private readonly ISportRepository _sportRepository;
        public Task<Guid> Handle(CreateSportMessage message, CancellationToken cancellationToken)
        {
            var sport = new Sport(message.Name);
            _sportRepository.CreateSport(sport);
            return Task.FromResult(sport.Id);

        }
    }
}
