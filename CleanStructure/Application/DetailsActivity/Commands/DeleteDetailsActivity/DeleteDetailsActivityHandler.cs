using Application.Activities.Commands.DeleteActivity;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Commands.DeleteDetailsActivity
{
    public class DeleteDetailsActivityHandler : IRequestHandler<DeleteDetailsActivityCommand, DetailActivity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteDetailsActivityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DetailActivity> Handle(DeleteDetailsActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _unitOfWork.DetailActivityRepository.GetDetailActivity(request.Id);
            await _unitOfWork.DetailActivityRepository.DeleteDetailActivity(activity);
            await _unitOfWork.Save();
            return activity;
        }
    }
    
}
