using Application.Activities;
using Application.Users.Queries.GetAllUsers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetAllActivitiesFromUser
{
    public class GetAllActivitiesFromUserQueryHandler: IRequestHandler<GetAllActivitiesFromUserQuery, List<ActivityDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllActivitiesFromUserQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<List<ActivityDTO>> Handle(GetAllActivitiesFromUserQuery request, CancellationToken cancellationToken)
        {
            var activityList = await _unitOfWork.ActivityRepository.GetActivities();
            var activitiesOfUser = new List<ActivityDTO>();
            activityList.ForEach(a =>
            {
                if (a.User.Email == request.Email)
                    activitiesOfUser.Add(_mapper.Map<ActivityDTO>(a));
                Console.WriteLine("asdas "+a.Id);
            });
            return _mapper.Map<List<ActivityDTO>>(activitiesOfUser);

        }
    }
        
}
