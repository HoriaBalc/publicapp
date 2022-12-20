using Application.Roles.Commands.DeleteRole;
using Application.Roles.Commands.UpdateRole;
using Application.Roles.Queries.GetAllRoles;
using Application.Roles.Queries.GetRoleByName;
using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Application.Activities;
using Application.Activities.Commands.CreateActivity;
using Application.Activities.Queries.GetAllActivities;
using Application.Activities.Queries.GetActivityById;
using Application.Activities.Commands.UpdateActivity;
using Application.Activities.Commands.DeleteActivity;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ActivityController(IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
            //_mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] ActivityDTO activityDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //RoleDTO roleDTO = new RoleDTO(name);
            var command = new CreateActivityCommand { dto = activityDTO };

            var result = await _mediator.Send(command);
            //var mappedResult = _mapper.Map<SportDTO>(result);

            return CreatedAtAction(nameof(CreateActivity), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            var result = await _mediator.Send(new GetAllActivitiesQuery());
            // var mappedResult = _mapper.Map<List<SportDTO>>(result);
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetActivityByID(Guid id)
        {
            var query = new GetActivityByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            //var mappedResult = _mapper.Map<string>(result);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateActivity([FromBody] ActivityDTO activityDTO)
        {
            var command = new UpdateActivityCommand
            {
                dto = activityDTO,
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            var command = new DeleteActivityCommand { Id = id };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}
