using Application.Activities.Commands.CreateActivity;
using Application.Activities.Commands.DeleteActivity;
using Application.Activities.Commands.UpdateActivity;
using Application.Activities.Queries.GetActivityById;
using Application.Activities.Queries.GetAllActivities;
using Application.Activities;
using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Application.PaceActivities.Commands.CreatePaceActivity;
using Application.PaceActivities;
using Application.PaceActivities.Queries.GetAllPaceActivities;
using Application.PaceActivities.Queries.GetPaceActivityById;
using Application.PaceActivities.Commands.DeletePaceActivity;
using Application.DTOs;
using AutoMapper;
using Application.PaceActivities.Commands.UpdatePaceActivity;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PaceActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaceActivityController(IMediator mediator, 
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaceActivity([FromBody] PaceActivityDTOCreateUpdate paceActivityDTOCreateUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreatePaceActivityCommand { dto = paceActivityDTOCreateUpdate };

            var result = await _mediator.Send(command);
            
            return CreatedAtAction(nameof(CreatePaceActivity), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaceActivities()
        {
            var result = await _mediator.Send(new GetAllPaceActivitiesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPaceActivityByID(Guid id)
        {
            var query = new GetPaceActivityByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePaceActivity([FromBody] PaceActivityDTO activityDTO)
        {
            var command = new UpdatePaceActivityCommand
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
        public async Task<IActionResult> DeletePaceActivity(Guid id)
        {
            var command = new DeletePaceActivityCommand { Id = id };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }

}
