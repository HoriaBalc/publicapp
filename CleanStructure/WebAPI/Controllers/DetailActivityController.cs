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
using Application.DetailsActivity;
using Application.DetailsActivity.Commands.CreateDetailsActivity;
using Application.DetailsActivity.Queries.GetAllDetailsActivities;
using Application.DetailsActivity.Queries.GetDetailsActivityById;
using Application.DetailsActivity.Commands.UpdateDetailsActivity;
using Application.DetailsActivity.Commands.DeleteDetailsActivity;
using Application.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DetailActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DetailActivityController(IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDetailActivity([FromBody] DetailsActivityDTOCreateUpdate detailsActivityDTOCreateUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreateDetailsActivityCommand { dto = detailsActivityDTOCreateUpdate };
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(CreateDetailActivity), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetDetailActivities()
        {
            var result = await _mediator.Send(new GetAllDetailsActivitiesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDetailActivityByID(Guid id)
        {
            var query = new GetDetailsActivityByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDetailActivity([FromBody] DetailActivityDTO detailActivityDTO)
        {
            var command = new UpdateDetailsActivityCommand
            {
                dto = detailActivityDTO,
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteDetailActivity(Guid id)
        {
            var command = new DeleteDetailsActivityCommand { Id = id };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}
