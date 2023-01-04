using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using AutoMapper;
using MediatR;
using Application;
using Application.Sports.Queries.GetAllSports;
using Application.Sports.Commands.UpdateSport;
using Application.Sports.Commands.DeleteSport;
using Application.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        private readonly IMediator _mediator;


        public SportController( IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSport([FromBody] NameDTO nameDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreateSportCommand { dto = nameDTO };

        var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(CreateSport), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSports()
        {
            var result = await _mediator.Send(new GetAllSportsQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetSportByName(string name)
        {
            var query = new GetSportByNameQuery { Name = name };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSport( [FromBody] SportDTO sportDTO)
        {
            var command = new UpdateSportCommand
            {
                dto = sportDTO,
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete]
        [Route("{name}")]
        public async Task<IActionResult> DeleteSport(string name)
        {
            var command = new DeleteSportCommand { Name = name };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }


    }

}
