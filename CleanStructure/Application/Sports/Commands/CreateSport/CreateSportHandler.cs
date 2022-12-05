using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateSportHandler : IRequestHandler<CreateSportCommand, Guid>
    {
        private readonly ISportRepository _sportRepository;

        public CreateSportHandler(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public Task<Guid> Handle(CreateSportCommand message, CancellationToken cancellationToken)
        {
            //var sport = new Sport(message.Name);
            var id=_sportRepository.CreateSport(message.Name);
            return Task.FromResult(id);

        }
    }
}
