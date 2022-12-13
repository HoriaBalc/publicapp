using Application.Sports.Commands.DeleteSport;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity = Domain.Activity;

namespace Application.Activities.Commands.DeleteActivity
{
    public class DeleteActivityHandler : IRequestHandler<DeleteActivityCommand, Activity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Activity> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.ActivityRepository.GetActivity(request.Id);
            await _unitOfWork.ActivityRepository.DeleteActivity(activity);
            await _unitOfWork.Save();
            return activity;
        }
    }
   
}
