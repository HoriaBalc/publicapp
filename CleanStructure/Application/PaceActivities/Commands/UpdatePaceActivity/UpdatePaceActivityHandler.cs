using Application.Activities.Commands.UpdateActivity;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Commands.UpdatePaceActivity
{
    public class UpdatePaceActivityHandler : IRequestHandler<UpdatePaceActivityCommand, PaceActivity>
    {
        // private readonly ISportRepository _sportRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePaceActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PaceActivity> Handle(UpdatePaceActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.PaceActivityRepository.GetPaceActivity(request.dto.Id);
            activity.Duration = request.dto.Duration;
            activity.Sport = request.dto.Sport;
            activity.Distance = request.dto.Distance;
            activity.ElevationGain = request.dto.ElevationGain;
            activity.ElevationLoss = request.dto.ElevationLoss;
            activity.User = request.dto.User;
            activity.InProgress = request.dto.InProgress;
            activity.StartDate = request.dto.StartDate;
            activity.Calories = request.dto.Calories;
            activity.Details = request.dto.Details;
            activity.Steps = request.dto.Steps;
            await _unitOfWork.ActivityRepository.UpdateActivity(activity);
            await _unitOfWork.Save();

            return activity;
        }
    }
}
