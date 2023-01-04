using Application.Sports.Commands.DeleteSport;
using Application.Sports.Commands.UpdateSport;
using Application.Sports.Queries.GetAllSports;
using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Application.Roles.Queries.GetAllRoles;
using Application.Roles.Queries.GetRoleByName;
using Application.Roles.Commands.UpdateRole;
using Application.Roles.Commands.DeleteRole;
using Application.DTOs;
using Application.Roles.Commands.AddUserToRole;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] NameDTO nameDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new CreateRoleCommand { dto = nameDTO };
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(CreateRole), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var result = await _mediator.Send(new GetAllRolesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetRoleByName(string name)
        {
            var query = new GetRoleByNameQuery { Name = name };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRole([FromBody] RoleDTO roleDTO)
        {
            var command = new UpdateRoleCommand
            {
                dto = roleDTO,
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpPut]
        [Route("addToRole")]
        public async Task<IActionResult> AddUserToRole([FromBody] UserRoleDTO dto)
        {
            var command = new AddUserToRoleCommand
            {
                RoleName = dto.RoleName,
                UserEmail = dto.UserEmail
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }


        [HttpDelete]
        [Route("{name}")]
        public async Task<IActionResult> DeleteRole(string name)
        {
            var command = new DeleteRoleCommand { Name = name };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }


    }
  
    
}
