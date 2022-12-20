﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using AutoMapper;
using MediatR;
using Application;
using Application.Sports.Queries.GetAllSports;
using Application.Sports.Commands.UpdateSport;
using Application.Sports.Commands.DeleteSport;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        //public readonly IMapper _mapper;
        public readonly IMediator _mediator;


        public SportController( IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
            //_mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSport([FromBody] string name)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            SportDTO sportDTO = new SportDTO(name);
            var command = new CreateSportCommand { dto = sportDTO };

        var result = await _mediator.Send(command);
        //var mappedResult = _mapper.Map<SportDTO>(result);

            return CreatedAtAction(nameof(CreateSport), result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSports()
        {
            var result = await _mediator.Send(new GetAllSportsQuery());
           // var mappedResult = _mapper.Map<List<SportDTO>>(result);
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

            //var mappedResult = _mapper.Map<string>(result);
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
