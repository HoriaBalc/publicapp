using Application.Sports.Queries.GetAllSports;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Queries.GetAllRoles
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, List<RoleDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllRolesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<RoleDTO>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var roleList = await _unitOfWork.RoleRepository.GetRoles();

            return _mapper.Map<List<RoleDTO>>(roleList);

        }
    }
   
}
