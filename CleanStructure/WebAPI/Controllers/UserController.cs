using Application.Sports.Commands.DeleteSport;
using Application.Sports.Commands.UpdateSport;
using Application.Sports.Queries.GetAllSports;
using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Application.Users;
using Application.Users.Commands.CreateUser;
using Application.Users.Queries.GetUserByEmail;
using Application.Users.Commands.UpdateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Queries.GetAllUsers;
using WebAPI.DTOs;
using Application.Roles.Queries.GetRoleByName;
using AutoMapper;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IMediator _mediator;
        public readonly IMapper _mapper;


        public UserController(IMediator mediator, IMapper mapper,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDTOCreateUpdate userDTOCreateUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var getRole = new GetRoleByNameQuery
            {
                Name = userDTOCreateUpdate.RoleName,
            };
            var role = await _mediator.Send(getRole);
            var roleDTO = _mapper.Map<RoleDTO>(role);
            Console.WriteLine(roleDTO.Name);
            UserDTO userDTO = new(userDTOCreateUpdate.FirstName, userDTOCreateUpdate.LastName, userDTOCreateUpdate.Email, userDTOCreateUpdate.Password, userDTOCreateUpdate.BirthDay, userDTOCreateUpdate.Height, userDTOCreateUpdate.Weight, userDTOCreateUpdate.Phone);
            var command = new CreateUserCommand { dto = userDTO, roleDto = roleDTO };

            var result = await _mediator.Send(command);
            var mappedResult = _mapper.Map<SportDTO>(result);

            return CreatedAtAction(nameof(CreateUser), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            // var mappedResult = _mapper.Map<List<SportDTO>>(result);
            return Ok(result);
        }

        [HttpGet]
        [Route("{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var query = new GetUserByEmailQuery { Email = email };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            //var mappedResult = _mapper.Map<string>(result);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO userDTO)
        {
            var command = new UpdateUserCommand
            {
                dto = userDTO,
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete]
        [Route("{email}")]
        public async Task<IActionResult> DeleteUser(string email)
        {
            var command = new DeleteUserCommand { Email = email };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
