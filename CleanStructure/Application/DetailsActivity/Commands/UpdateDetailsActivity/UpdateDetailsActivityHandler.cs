using Application.Activities.Commands.UpdateActivity;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Commands.UpdateDetailsActivity
{
    public class UpdateDetailsActivityHandler : IRequestHandler<UpdateDetailsActivityCommand, DetailActivity>
    {
        // private readonly ISportRepository _sportRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateDetailsActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DetailActivity> Handle(UpdateDetailsActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.DetailActivityRepository.GetDetailActivity(request.dto.Id);
            activity.Duration = request.dto.Duration;
            activity.Distance = request.dto.Distance;
            activity.ElevationGain = request.dto.ElevationGain;
            activity.ElevationLoss = request.dto.ElevationLoss;
            activity.Calories = request.dto.Calories;
            activity.Activity = request.dto.Activity;
            await _unitOfWork.DetailActivityRepository.UpdateDetailActivity(activity);
            await _unitOfWork.Save();
            return activity;
        }
    }
}
