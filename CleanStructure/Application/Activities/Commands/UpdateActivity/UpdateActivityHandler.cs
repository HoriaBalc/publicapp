using Application.Sports.Commands.UpdateSport;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Commands.UpdateActivity
{
    public class UpdateActivityHandler : IRequestHandler<UpdateActivityCommand, Activity>
    {
        // private readonly ISportRepository _sportRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Activity> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.ActivityRepository.GetActivity(request.dto.Id);
            activity.Duration = request.dto.Duration;
            activity.Distance = request.dto.Distance;
            activity.ElevationGain = request.dto.ElevationGain;
            activity.ElevationLoss = request.dto.ElevationLoss;
            activity.InProgress = request.dto.InProgress;
            activity.StartDate = request.dto.StartDate;
            activity.Calories = request.dto.Calories;
            await _unitOfWork.ActivityRepository.UpdateActivity(activity);
            await _unitOfWork.Save();

            return activity;
        }
    }
}
