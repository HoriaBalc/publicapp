﻿using Application.Sports.Commands.UpdateSport;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Commands.UpdateUser
{
    internal class UpdateUserHandler : IRequestHandler<UpdateUserCommand, User>
    {
        // private readonly ISportRepository _sportRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUserHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetUser(request.dto.Email);
            user.FirstName = request.dto.FirstName;
            user.LastName = request.dto.LastName;
            user.BirthDay = request.dto.BirthDay;
            user.Phone = request.dto.Phone;
            user.Height = request.dto.Height;
            user.Weight = request.dto.Weight;
            await _unitOfWork.UserRepository.UpdateUser(user);
            await _unitOfWork.Save();

            return user;
        }
    }
   
}
