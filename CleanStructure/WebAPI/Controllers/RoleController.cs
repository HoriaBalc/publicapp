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
using WebAPI.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        //public readonly IMapper _mapper;
        public readonly IMediator _mediator;

        public RoleController(IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
            //_mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] NameDTO name)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            RoleDTO roleDTO = new RoleDTO(name.Name);
            var command = new CreateRoleCommand { dto = roleDTO };

            var result = await _mediator.Send(command);
            //var mappedResult = _mapper.Map<SportDTO>(result);

            return CreatedAtAction(nameof(CreateRole), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var result = await _mediator.Send(new GetAllRolesQuery());
            // var mappedResult = _mapper.Map<List<SportDTO>>(result);
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

            //var mappedResult = _mapper.Map<string>(result);
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
