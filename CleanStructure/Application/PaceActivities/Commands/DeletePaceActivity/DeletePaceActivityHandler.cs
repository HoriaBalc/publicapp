using Application.Activities.Commands.DeleteActivity;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Commands.DeletePaceActivity
{
    public class DeletePaceActivityHandler : IRequestHandler<DeletePaceActivityCommand, PaceActivity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeletePaceActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PaceActivity> Handle(DeletePaceActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.PaceActivityRepository.GetPaceActivity(request.Id);
            await _unitOfWork.PaceActivityRepository.DeletePaceActivity(activity);
            await _unitOfWork.Save();
            return activity;
        }
    }
    
}
