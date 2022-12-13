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

            var activity = new Activity();           
            var id = await _unitOfWork.ActivityRepository.CreateActivity(activity);
            await _unitOfWork.Save();
            return id;

        }
    }
   
}
