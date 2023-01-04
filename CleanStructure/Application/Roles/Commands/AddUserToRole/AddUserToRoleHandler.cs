using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Commands.AddUserToRole
{
    internal class AddUserToRoleHandlerr : IRequestHandler<AddUserToRoleCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddUserToRoleHandlerr(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(AddUserToRoleCommand request, CancellationToken cancellationToken)
        {

            var sp = await _unitOfWork.RoleRepository.AddUserToRole(request.UserEmail, request.RoleName);

            await _unitOfWork.Save();
            return sp;

        }
    }
  
}
