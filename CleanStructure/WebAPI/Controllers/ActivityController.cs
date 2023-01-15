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
using Application.DTOs;
using AutoMapper;
using Application.Users.Queries.GetAllActivitiesFromUser;
using Application.Activities.Queries.GetAllDetailActivitiesFromActivity;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivityController(IMediator mediator, 
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] ActivityDTOCreateUpdate activityDTOCtreateUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreateActivityCommand { dto = activityDTOCtreateUpdate };

            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(CreateActivity), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            var result = await _mediator.Send(new GetAllActivitiesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("GetDetailActivities/{id}")]
        public async Task<IActionResult> GetDetailActivitiesOfActivity(Guid id)
        {
            var query = new GetAllDetailsActivitiesFromActivityQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

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
