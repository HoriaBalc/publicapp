using Application.Sports.Commands.UpdateSport;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Commands.UpdateRole
{
    public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, Role>
    {
       // private readonly ISportRepository _sportRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRoleHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Role> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _unitOfWork.RoleRepository.GetRole(request.dto.Name);
            role.Id = request.dto.Id;
            role.Users = request.dto.Users;
            await _unitOfWork.RoleRepository.UpdateRole(role);
            await _unitOfWork.Save();

            return role;
        }
    
    }
}
