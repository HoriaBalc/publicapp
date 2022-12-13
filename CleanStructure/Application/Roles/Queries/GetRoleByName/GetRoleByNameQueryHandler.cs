using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Queries.GetRoleByName
{
    public class GetRoleByNameQueryHandler : IRequestHandler<GetRoleByNameQuery, Role>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetRoleByNameQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Role> Handle(GetRoleByNameQuery request, CancellationToken cancellationToken)
        {
            var role = await _unitOfWork.RoleRepository.GetRole(request.Name);
            return role;
        }
    }
  
}
