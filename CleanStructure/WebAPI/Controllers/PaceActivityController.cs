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

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PaceActivityController : ControllerBase
    {
        public readonly IMediator _mediator;

        public PaceActivityController(IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
            //_mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaceActivity([FromBody] PaceActivityDTO paceActivityDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //RoleDTO roleDTO = new RoleDTO(name);
            var command = new CreatePaceActivityCommand { dto = paceActivityDTO };

            var result = await _mediator.Send(command);
            //var mappedResult = _mapper.Map<SportDTO>(result);

            return CreatedAtAction(nameof(CreatePaceActivity), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaceActivities()
        {
            var result = await _mediator.Send(new GetAllPaceActivitiesQuery());
            // var mappedResult = _mapper.Map<List<SportDTO>>(result);
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

            //var mappedResult = _mapper.Map<string>(result);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePaceActivity([FromBody] ActivityDTO activityDTO)
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
