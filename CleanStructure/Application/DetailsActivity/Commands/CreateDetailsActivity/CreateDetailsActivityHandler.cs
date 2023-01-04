using Application.Activities.Commands.CreateActivity;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Commands.CreateDetailsActivity
{
    public class CreateDetailsActivityHandler : IRequestHandler<CreateDetailsActivityCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateDetailsActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateDetailsActivityCommand request, CancellationToken cancellationToken)
        {
            Activity activity = await _unitOfWork.ActivityRepository.GetActivity(request.dto.ActivityId);
            Console.WriteLine(activity.Duration);
            DetailActivity detailActivity = new DetailActivity(request.dto.Duration, request.dto.Distance, request.dto.ElevationGain, request.dto.ElevationLoss, request.dto.Calories, activity);
            //activity.Details.Add(detailActivity);
            var id = await _unitOfWork.DetailActivityRepository.CreateDetailActivity(detailActivity);
            await _unitOfWork.Save();
            return id;

        }
    }
  
}
