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
       // private readonly ISportRepository _sportRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateSportHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Sport> Handle(UpdateSportCommand request, CancellationToken cancellationToken)
        {
            var sport = await _unitOfWork.SportRepository.GetSport(request.dto.Name);
            //sport.Id = request.dto.Id;
            if (sport != null)
            {
                // to do: add activity to sport 
                // sport.Activities = request.dto.Activities;
                await _unitOfWork.SportRepository.UpdateSport(sport);
                await _unitOfWork.Save();
            }
            return sport;
        }
    }
   
}
