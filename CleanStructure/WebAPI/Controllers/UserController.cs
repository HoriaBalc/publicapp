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
using Application.DTOs;
using Application.Roles.Queries.GetRoleByName;
//using AutoMapper;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using AutoMapper;
using Application.Users.Queries.GetAllActivitiesFromUser;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;


        public UserController(IMediator mediator, 
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDTOCreateUpdate userDTOCreateUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreateUserCommand { dto = userDTOCreateUpdate };
            var result = await _mediator.Send(command);
            Console.WriteLine(result.ToString());
            return CreatedAtAction(nameof(CreateUser), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("activities/{email}")]
        public async Task<IActionResult> GetActivitiesOfUser(string email)
        {
            var query = new GetAllActivitiesFromUserQuery { Email = email };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUser/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var query = new GetUserByEmailQuery { Email = email };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

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
