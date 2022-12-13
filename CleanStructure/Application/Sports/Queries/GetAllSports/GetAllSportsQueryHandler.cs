using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Queries.GetAllSports
{
    public class GetAllSportsQueryHandler : IRequestHandler<GetAllSportsQuery, List<Sport>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetAllSportsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<Sport>> Handle(GetAllSportsQuery request, CancellationToken cancellationToken)
        {
            var sportList = await _unitOfWork.SportRepository.GetSports();

            return sportList;

        }
    }
    
}
