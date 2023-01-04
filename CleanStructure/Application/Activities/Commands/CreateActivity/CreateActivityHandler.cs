using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Commands.CreateActivity
{
    public class CreateActivityHandler : IRequestHandler<CreateActivityCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            Sport sport = await _unitOfWork.SportRepository.GetSport(request.dto.SportName); 
            User user = await _unitOfWork.UserRepository.GetUserByEmail(request.dto.UserEmail);
            var activity = new Activity(request.dto.Duration, request.dto.StartDate, request.dto.Distance, request.dto.ElevationGain, request.dto.ElevationLoss, request.dto.Calories, sport, user);           
            var id = await _unitOfWork.ActivityRepository.CreateActivity(activity);
            await _unitOfWork.Save();
            return id;

        }
    }
   
}
