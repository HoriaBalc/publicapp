using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateSportHandler : IRequestHandler<CreateSportCommand, string>
    {
        private readonly ISportRepository _sportRepository;

        public CreateSportHandler(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public async Task<string> Handle(CreateSportCommand request, CancellationToken cancellationToken)
        {
            
            var sport = new Sport(request.dto.Name);
            //var sportDto = new SportDTO(sport);
            //var s = new Sport(request.Name);
            var sp=await _sportRepository.CreateSport(sport);
            return sp;

        }
    }
}
