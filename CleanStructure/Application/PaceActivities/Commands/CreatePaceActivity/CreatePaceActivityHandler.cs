using Application.Activities.Commands.CreateActivity;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Commands.CreatePaceActivity
{
    public class CreatePaceActivityHandler : IRequestHandler<CreatePaceActivityCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreatePaceActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreatePaceActivityCommand request, CancellationToken cancellationToken)
        {
            Sport sport = await _unitOfWork.SportRepository.GetSport(request.dto.SportName);
            User user = await _unitOfWork.UserRepository.GetUserByEmail(request.dto.UserEmail);
            var activity = new PaceActivity(request.dto.Duration, request.dto.StartDate, request.dto.Distance, request.dto.ElevationGain, request.dto.ElevationLoss, request.dto.Calories, sport, user);
            var id = await _unitOfWork.ActivityRepository.CreateActivity(activity);
            await _unitOfWork.Save();
            return id;
           

        }
    }
    
}
