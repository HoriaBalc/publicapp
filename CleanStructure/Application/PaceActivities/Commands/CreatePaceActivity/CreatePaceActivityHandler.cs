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

            var activity = new PaceActivity();
            var id = await _unitOfWork.PaceActivityRepository.CreatePaceActivity(activity);
            await _unitOfWork.Save();
            return id;

        }
    }
    
}
