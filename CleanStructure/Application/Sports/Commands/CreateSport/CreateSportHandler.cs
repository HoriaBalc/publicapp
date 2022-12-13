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
        private readonly IUnitOfWork _unitOfWork;
        public CreateSportHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(CreateSportCommand request, CancellationToken cancellationToken)
        {
            
            var sport = new Sport(request.dto.Name);
            //var sportDto = new SportDTO(sport);
            //var s = new Sport(request.Name);
            var sp=await _unitOfWork.SportRepository.CreateSport(sport);
            await _unitOfWork.Save();
            return sp;

        }
    }
}
