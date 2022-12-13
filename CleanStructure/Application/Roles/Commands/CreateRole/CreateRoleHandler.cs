using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateRoleHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {

            var role = new Role(request.dto.Name);
            
            var sp = await _unitOfWork.RoleRepository.CreateRole(role);
            await _unitOfWork.Save();
            return sp;

        }
    }
    
}
