using Application.DetailsActivity;
using Application.Users.Queries.GetAllActivitiesFromUser;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetAllDetailActivitiesFromActivity
{
    public class GetAllDetailsActivitiesFromActivityQueryHandler : IRequestHandler<GetAllDetailsActivitiesFromActivityQuery, List<DetailActivityDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllDetailsActivitiesFromActivityQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<List<DetailActivityDTO>> Handle(GetAllDetailsActivitiesFromActivityQuery request, CancellationToken cancellationToken)
        {
            var detailActivityList = await _unitOfWork.DetailActivityRepository.GetDetailActivities();
            var activitiesOfUser = new List<DetailActivityDTO>();
            detailActivityList.ForEach(a =>
            {
                if (a.Activity.Id.Equals( request.Id))
                    activitiesOfUser.Add(_mapper.Map<DetailActivityDTO>(a));
                Console.WriteLine("asdas " + a.Id);
            });
            return activitiesOfUser;

        }
    }
   
}
