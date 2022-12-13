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
        private readonly IUnitOfWork _unitOfWork;

        public DeleteSportHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Sport> Handle(DeleteSportCommand request, CancellationToken cancellationToken)
        {
            var sport = await _unitOfWork.SportRepository.GetSport(request.Name);
            await _unitOfWork.SportRepository.DeleteSport(sport);
            await _unitOfWork.Save();
            return sport;
        }
    }
    
}
