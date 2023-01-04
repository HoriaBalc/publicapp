using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Queries.GetRoleByName
{
    public class GetRoleByNameQueryHandler : IRequestHandler<GetRoleByNameQuery, RoleDTO>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetRoleByNameQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<RoleDTO> Handle(GetRoleByNameQuery request, CancellationToken cancellationToken)
        {
            var role = await _unitOfWork.RoleRepository.GetRole(request.Name);
            return _mapper.Map<RoleDTO>(role);
        }
    }
  
}
