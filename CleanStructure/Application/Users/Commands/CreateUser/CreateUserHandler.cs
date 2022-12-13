using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var user = new User(request.dto.FirstName, request.dto.LastName,request.dto.Email, request.dto.Password, request.dto.Role);
            var u = await _unitOfWork.UserRepository.CreateUser(user);
            await _unitOfWork.Save();
            return u;

        }
    }
   
}
